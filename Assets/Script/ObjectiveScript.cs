using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectiveScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(new Vector3(90, 0, 180) * Time.deltaTime); //Simple Line of code to make the objective rotate
    }

    public void Collision()
    {
        Destroy(gameObject);
    }
}
