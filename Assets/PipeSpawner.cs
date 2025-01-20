using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
    public GameObject Pipe;
    public float spawnrate = 2;
    public float timer;
    public float hoff = 3;

    // Start is called before the first frame update
    void Start()
    {
        Spawnpipe();
    }

    // Update is called once per frame
    void Update()
    {
        if(timer<spawnrate)
            timer = timer + Time.deltaTime;
        else
        {
            Spawnpipe();
            timer = 0;
        }
        

    }
    void Spawnpipe()
    {
        float low = transform.position.y - hoff;
        float high = transform.position.y + hoff;
        Instantiate(Pipe,new Vector3(transform.position.x,Random.Range(low,high),0), transform.rotation);
       
    }
}
