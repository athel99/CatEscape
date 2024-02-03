using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class BamsongiGenerator : MonoBehaviour
{
    [SerializeField] GameObject bamsngiprefab;
   
    
    
   
    void Update()
    {
        //화면을 터치하면 밤송이 생성

        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log(Input.mousePosition);

            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            Debug.Log(ray);
            Vector3 direct = Vector3.Normalize(ray.direction);


            GameObject Go = Instantiate(this.bamsngiprefab);
            Go.GetComponent<BamsongiController>().direct = -direct; //밤송이가 날아가는 방향에 따라 조절해주기

        }








    }
}
