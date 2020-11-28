using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerJump : MonoBehaviour
{

    Rigidbody2D myrigid;
    [SerializeField]
    private float power;
    [SerializeField]
    Transform pos;
    [SerializeField]
    float cheakRadius;
    [SerializeField]
    LayerMask islayer;

    bool isGround;
    // Start is called before the first frame update
    void Start()
    {
        myrigid = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        isGround = Physics2D.OverlapCircle(pos.position, cheakRadius, islayer);
        if (isGround == true && Input.GetKeyDown(KeyCode.Space))
        {
            myrigid.velocity = Vector2.up * power;
        }
    }

}
