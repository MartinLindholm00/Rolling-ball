using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class SpawnerScript : MonoBehaviour
{
    public GameObject Opjective;
    public int SpawnTimer = 10;
    public Vector3 Size;
    public Vector3 Center;

    //Vector2 SpawnArea = new Vector2 ();

    // Start is called before the first frame update
    void Start()
    {
        spawnObjective();
        InvokeRepeating("spawnObjective", SpawnTimer, SpawnTimer);
    }

    // Update is called once per frame
    void Update()
    { 
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

    public void spawnObjective ()
    {
        Vector3 pos = Center + new Vector3(Random.Range(-Size.x / 2, Size.x / 2), 1, Random.Range(-Size.z / 2, Size.z / 2));
        Instantiate(Opjective, pos, transform.rotation);
    }
}
