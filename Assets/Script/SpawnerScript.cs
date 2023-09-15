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

    // Start is called before the first frame update
    void Start()
    {
        spawnObjective();
        InvokeRepeating(nameof(spawnObjective), SpawnTimer, SpawnTimer); /* I have desided to use an Invoke method
                                                                            to reapeat the SpawnObjective Methode */
    }

    // Update is called once per frame
    void Update()
    { 
    }

    private void FixedUpdate()
    {

    }

    public void spawnObjective ()
    {
        Vector3 pos = Center + new Vector3(Random.Range(-Size.x / 2, Size.x / 2), 1, Random.Range(-Size.z / 2, Size.z / 2));
        Instantiate(Opjective, pos, transform.rotation);
    }
}
