using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class SpawnerScript : MonoBehaviour
{
    public GameObject Opjective;
    public int Timer = 10;
    public int SpawnArea;

    // Start is called before the first frame update
    void Start()
    {
        Instantiate(Opjective);
    }

    // Update is called once per frame
    void Update()
    {
        if (Timer == 0 )
        {
            Instantiate(Opjective);
            Timer = 10;
        }
    }
}
