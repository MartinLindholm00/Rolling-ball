using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerScript : MonoBehaviour
{
    private LogicScript Logic;
    private ObjectiveScript Objective;

    public float speedForce = 1.0f;

    private float movementX;
    private float movementY;

    public Rigidbody RB;

    // Start is called before the first frame update
    void Start()
    {
        Logic = GameObject.FindGameObjectWithTag("LogicTag").GetComponent<LogicScript>();

    }

    //I am using FixedUpdate since i am using physics methodes. That way, the game will run more smothly
    private void FixedUpdate()
    {
        Vector3 movement = new Vector3 (movementX, 0.0f, movementY);
        RB.AddForce(movement * speedForce);
    }

    // Update is called once per frame
    void Update()
    {
        GameObject[] objectiveCubes;
        objectiveCubes = GameObject.FindGameObjectsWithTag("ObjectiveTag");
    }

    //This methode is used since i am using the "Player Input" component in Unity
    //This then makes the inputs into vectors for me to add force with
    void OnMove(InputValue movementValue)
    {
        Vector2 movementVector = movementValue.Get<Vector2>();

        movementX = movementVector.x;
        movementY = movementVector.y;
    }
}
