using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;



public class ArrowGenerater : MonoBehaviour
{
   


    //������ ������ ������ ������ �ν��Ͻ��� ����� 
    [SerializeField] private GameObject arrowPrefab;
   

    private float delta; //����� �ð�
   


    void Update()
    {
       
            delta += Time.deltaTime; //������ ���� �����ӻ����� �ð�
                                     //Debug.Log(delta);

            if (delta>3) //3�� �������� ���� 
            {
                GameObject go = UnityEngine.Object.Instantiate(this.arrowPrefab);// ������ ���� 
                                                                                 //��ġ �缳��
                float ransX = UnityEngine.Random.Range(-8, 9); // x�� ���� ���� ���� 
                go.transform.position
                    = new Vector3(ransX, go.transform.position.y, go.transform.position.z);

                delta = 0; //����ð��� �ʱ�ȭ 
            }
        
        




    }

   
    

}
