using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{
    public GameObject Player;

    private Vector3 offset;

    // Start is called before the first frame update
    void Start()
    {
        offset = transform.position - Player.transform.position; // Find out what the distance is between the camera and the player
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Player.transform.position + offset; 
        //Make sure that that distance stays that distance by constently changing the cameras position
    }
}
