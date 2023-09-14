using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class SpawnerScript : MonoBehaviour
{
    public GameObject Opjective;
    public int SpawnTimer = 10;
    private Vector2 SpawnArea;

    //Vector2 SpawnArea = new Vector2 ();

    // Start is called before the first frame update
    void Start()
    {
        Instantiate(Opjective );
    }

    // Update is called once per frame
    void Update()
    {
        if (SpawnTimer > 0)
        {
          //  SpawnTimer = SpawnTimer - Time.deltaTime;
        }
        if (SpawnTimer == 0)
        {
            //Instantiate(Opjective);
            SpawnTimer = 10;
        }
    }

    private void FixedUpdate()
    {
        Debug.Log(SpawnTimer);
    }

    float UpdateTimer(float CurrentTime)
    {
        CurrentTime -= 1;

        float minutes = Mathf.FloorToInt(CurrentTime / 60);
        float secunds = Mathf.FloorToInt(CurrentTime % 60);
        return CurrentTime;
    }
}
