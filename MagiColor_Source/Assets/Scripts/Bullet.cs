using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed;
    public float distance;
    public LayerMask isLayer;
    public GameObject d;
    
    // Start is called before the first frame update
    void Start()
    {
        Invoke("DestroyBullet", 5);
    }

    private void OnTriggerEnter2D(Collider2D c)
    {
        if (c.gameObject.tag == "Enemy")
        {
            Destroy(c.gameObject);
            Destroy(gameObject);
        }
    }
    // Update is called once per frame
    void Update()
    {
        RaycastHit2D ray = Physics2D.Raycast(transform.position
            , transform.up, distance, isLayer);
        transform.Translate(transform.up * speed *3* Time.deltaTime);
        Destroy(d, 5);
    }

    void Changecolor()
    {
        EnemyColor e = new EnemyColor();
        BulletColor b = new BulletColor();

        e.sp.color = b.sp.color;
    }
   
}
