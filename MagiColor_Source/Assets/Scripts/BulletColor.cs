using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading;

public class BulletColor : MonoBehaviour
{
    public SpriteRenderer sp;
    // Start is called before the first frame update
    void Start()
    {
        
        
        sp = gameObject.GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        
            if (Input.GetKeyDown(KeyCode.Alpha1)) { sp.color = new Color(1, 0, 0, 1); }

            if (Input.GetKeyDown(KeyCode.Alpha2)) { sp.color = new Color(0, 1, 0, 1); }

            if (Input.GetKeyDown(KeyCode.Alpha3)) { sp.color = new Color(0, 0, 1, 1); }
         
    }

}
