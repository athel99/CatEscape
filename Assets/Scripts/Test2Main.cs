using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Test2Main : MonoBehaviour
{
    public GameObject basket;

    void Update()
    {
        //화면을 클릭하면 레이를 발사
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            //레이 속성 
            //ray.origin 시작위치
               // ray.direction 방향

            Debug.DrawRay(ray.origin, ray.direction*20f,Color.red,10);

            //레이와 콜라이더의 충돌체크 

            RaycastHit hit; // 충돌지점
            if (Physics.Raycast(ray.origin, ray.direction, out hit, 20))
            {
                Debug.Log("충돌함");
                Debug.LogFormat("충돌지점={0}",hit.point);
                //this.cubeTransform.position=hit.point;

               

            }


            int x = Mathf.RoundToInt(hit.point.x);
            int y = Mathf.RoundToInt(hit.point.y);

            this.basket.transform.Translate( hit.point);


        }
    }
}
