using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundColor : MonoBehaviour
{
    Camera col;
    float timer;
    int waitingTime;
    // Start is called before the first frame update
    void Start()
    {
        timer = 0.0f;
        waitingTime = 7;
        col = GetComponent<Camera>();
    }

    // Update is called once per frame
    void Update()
    {
        
            timer += Time.deltaTime;

            if (timer > waitingTime)
            {
                col.backgroundColor = new Color(Random.Range(0.1f, 1), Random.Range(0.1f, 1), Random.Range(0.1f, 1));
                timer = 0;
            }
        }
        
    
}
