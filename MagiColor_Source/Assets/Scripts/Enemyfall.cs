using UnityEngine;
using System.Collections;

public class Enemyfall : MonoBehaviour
{

    private static Enemyfall instance;

    public GameObject enemy;

    void Awake()
    {
        instance = this;
    }

    void Start()
    {
        InvokeRepeating("CreateEnemy", 1f, 1.8f * (Random.Range(7, 10) / 10f));
    }

    void Update()
    {
    }

    void CreateEnemy()
    {
        Instantiate(enemy);
    }

    public static void Cancel()
    {
        instance.CancelInvoke();
    }
}
