using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class birdFlying : MonoBehaviour
{
    public Rigidbody2D myrigidbody;
    public float flapspeed = 4;
    public LogicScript logic;
    public bool birdIsAlive = true;
    public AudioSource Bird;
    public Animation flap;
    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("logic").GetComponent<LogicScript>();
        Bird.Play();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space) == true && birdIsAlive == true)
        {
            
            myrigidbody.velocity = Vector3.up * flapspeed;
        }
        if(transform.position.y<=-6.07||transform.position.y>=6.07)
        {
            logic.GameOver();
            birdIsAlive=false;
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        logic.GameOver();
        birdIsAlive = false;
    }
}
