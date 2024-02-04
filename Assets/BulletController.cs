using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UIElements;

public class BulletController : MonoBehaviour
{
    public float speed=4f;
   private Vector3 pos;
     public GameObject explosion;
    public GameObject[] item;
   

    void Update()
    {


        // ���� �Ѿ� �߻�
        this.transform.Translate(Vector2.up * this.speed * Time.deltaTime);

        //ȭ�� ������ ������ �������
        if (this.transform.position.y >6.56f)
        {
            Destroy(this.gameObject);
        }


    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
      
       
        //���̶� �浹�ϸ� �����

        if (collision.tag == "Enemy") //�±� ���� 
        {
            
            Destroy(collision.gameObject); //�� �Ҹ�
            Destroy(this.gameObject); //�Ѿ� �Ҹ� 
            //���� ������ ����
              Instantiate(explosion,this.transform.position, Quaternion.identity);
           
             int temp = UnityEngine.Random.Range(0, 3);
            Instantiate(item[temp], this.transform.position, Quaternion.identity);

        }

       

    }
}
