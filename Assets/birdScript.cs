using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class birdScript : MonoBehaviour
{
    //public, so we can access it from anywhere in the script
    public Rigidbody2D myRigidBody;
    public float flapStrength;
    public LogicScript logic;
    public bool alive = true;

    // Start is called before the first frame update
    // Runs only once
    //initally this script can only talk to the game object
    //top level settings and the transform related settings
    //so we make a special slot for rigidBody2D
    //to send it commands, this is called a refernce
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
    }

    // Update is called once per frame
    // Runs constantly every line of code every frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) == true && alive == true){
            myRigidBody.velocity = Vector2.up * flapStrength;//shorthand for (0, 1) 
        }

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        logic.gameOver();
        alive = false;
    }
}
