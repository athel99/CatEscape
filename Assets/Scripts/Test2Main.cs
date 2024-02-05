using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Test2Main : MonoBehaviour
{
    public GameObject basket;

    void Update()
    {
        //ȭ���� Ŭ���ϸ� ���̸� �߻�
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            //���� �Ӽ� 
            //ray.origin ������ġ
               // ray.direction ����

            Debug.DrawRay(ray.origin, ray.direction*20f,Color.red,10);

            //���̿� �ݶ��̴��� �浹üũ 

            RaycastHit hit; // �浹����
            if (Physics.Raycast(ray.origin, ray.direction, out hit, 20))
            {
                Debug.Log("�浹��");
                Debug.LogFormat("�浹����={0}",hit.point);
                //this.cubeTransform.position=hit.point;

               

            }


            int x = Mathf.RoundToInt(hit.point.x);
            int y = Mathf.RoundToInt(hit.point.y);

            this.basket.transform.Translate( hit.point);


        }
    }
}
