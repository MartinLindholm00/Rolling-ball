using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectiveScript : MonoBehaviour
{
    public GameObject Player;
    public LogicScript Logic;

    // Start is called before the first frame update
    void Start()
    {
        Logic = GameObject.FindGameObjectWithTag("LogicTag").GetComponent<LogicScript>();
        Player = GameObject.FindGameObjectWithTag("PlayerTag");
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(new Vector3(90, 0, 180) * Time.deltaTime); //Simple Line of code to make the objective rotate
    }

    private void OnTriggerEnter(Collider Player)
    {
        Logic.AddScore(1);
        Collision();
    }

    public void Collision()
    {
        Destroy(gameObject);
    }
}
