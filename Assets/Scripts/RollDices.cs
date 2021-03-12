using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RollDices : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void rollDices()
    {
        int randomDiceSide1 = 0;
        int randomDiceSide2 = 0;

        randomDiceSide1 = Random.Range(1, 7);
        randomDiceSide2 = Random.Range(1, 7);

        GameManager.Instance.diceRoll(randomDiceSide1 , randomDiceSide2);
    }
} 

 
