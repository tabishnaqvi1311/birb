using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pipeMiddleScript : MonoBehaviour
{
    public LogicScript logic;
    // Start is called before the first frame update
    void Start()
    {
        //we are just searching for the logic script
        //same as dragging and dropping it unity
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //anything in this function will run whenever
        //an object hits the trigger
        if(collision.gameObject.layer == 3)
        {
            logic.addScore(1);
        }
    }
}
