using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyColor : MonoBehaviour
{
    public SpriteRenderer sp;
    // Start is called before the first frame update
    void Start()
    {
        sp = gameObject.GetComponent<SpriteRenderer>();
        colr();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void colr()
    {
        switch(Random.Range(1, 7))
        {
            case 1:
                sp.color = new Color(1, 0, 0);
                break;
            case 2:
                sp.color = new Color(1, 0.5f, 0);
                break;
            case 3:
                sp.color = new Color(1, 1, 0);
                break;
            case 4:
                sp.color = new Color(0, 1, 0);
                break;
            case 5:
                sp.color = new Color(0, 1, 1);
                break;
            case 6:
                sp.color = new Color(0, 0, 1);
                break;
            case 7:
                sp.color = new Color(1, 0, 1);
                break;
            case 8:
                sp.color = new Color(1, 1, 1);
                break;
        }
    }
}
