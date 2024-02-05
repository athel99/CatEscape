using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppleItemGenerator : MonoBehaviour
{
    public GameObject[] item;
    private float delta = 0f;
    private float span = 2f;

    void Start()
    {  // 아이템 랜덤 생성
       // int temp = UnityEngine.Random.Range(0, 2);
       // Instantiate(item[temp], this.transform.position, Quaternion.identity);
    }

   
    void Update()
    {
      delta = Time.deltaTime;
        if(delta > span)
        {
            int temp = UnityEngine.Random.Range(0, 2);
            Instantiate(item[temp], this.transform.position, Quaternion.identity);

            delta = 0;
        }

    }
}
