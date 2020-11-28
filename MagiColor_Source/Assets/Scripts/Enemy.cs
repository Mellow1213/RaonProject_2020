using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{

    private bool right;

    void Start()
    {
        
            GetComponent<Rigidbody2D>().transform.position = new Vector2(Random.Range(24f,-24f), 0f);
            GetComponent<Rigidbody2D>().velocity = new Vector2(-5f, GetComponent<Rigidbody2D>().velocity.y);
        
    }

    void Update()
    {

    }

    void OnCollisionEnter2D(Collision2D c)
    {
        if (c.gameObject.tag == "Floor")
        {
            Destroy(c.gameObject);
            Destroy(gameObject);
        }        
    }


 
}