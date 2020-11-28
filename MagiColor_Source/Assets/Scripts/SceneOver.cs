using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneOver : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R)|| Input.GetKeyDown(KeyCode.A))
            SceneManager.LoadScene("Ingame");
        if (Input.GetKeyDown(KeyCode.M))
            SceneManager.LoadScene("StartMenu");
        if (Input.GetKeyDown(KeyCode.Escape))
            Application.Quit();
    }
}
