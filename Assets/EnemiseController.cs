using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemiseController : MonoBehaviour
{
    public GameObject enemy1;
    public GameObject enemy2;

    void Start()
    {
        
    }

    
    void Update()
    {
        float enemyX = enemy1.transform.position.x;
        float enemyY = enemy1.transform.localPosition.y;

        transform.position = Vector3.zero;

    }
}
