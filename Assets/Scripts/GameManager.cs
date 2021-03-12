using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }

    public Transform[] waypoints;
    public List<GameObject> jugadores;
    public int turno = 0;

    private Text turnoJugador;
    private Text tirada;
    private Text tiraDeNuevo;

    private void Awake() { 
        if(Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        turnoJugador = GameObject.Find("Canvas/turnoJugador").GetComponent<Text>();
        turnoJugador.text = $"jugador {turno+1}";
        tirada = GameObject.Find("Canvas/tirada").GetComponent<Text>();
        tiraDeNuevo = GameObject.Find("Canvas/TiraDeNuevo").GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        turnoJugador.text = $"jugador {turno + 1}";
    }

    public void pasarTurno()
    {
        if(turno + 1 > jugadores.Count - 1)
        {
            turno = 0;
        }else{
            turno++;
        }
    }

    public void diceRoll(int x, int y)
    {
        jugadores[turno].GetComponent<FollowThePath>().Move(x + y);
        cambiarTirada(x , y);

        if (x != y)
        {
            pasarTurno();
            tiraDeNuevo.text = "";
        }
        else
        {
            tiraDeNuevo.text = "Tira De Nuevo";
        }
    }

    private void cambiarTirada(int x, int y)
    {
        tirada.text = $"{x + y} = {x} + {y}";
    }
}
