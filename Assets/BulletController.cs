using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class BulletController : MonoBehaviour
{
    public float speed=4f;
   private Vector3 pos;
  /// private Animator boom;

    //private Vector3 boomPosition;

    void Update()
    {


        // ���� �Ѿ� �߻�
        this.transform.Translate(Vector2.up * this.speed * Time.deltaTime);

        //ȭ�� ������ ������ �������
        if (this.transform.position.y > 6.56f)
        {
            Destroy(this.gameObject);
        }


    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
      
       
        //���̶� �浹�ϸ� �����

        if (collision.tag == "Enemy") //�±� ���� 
        {
           // this.boomPosition = this.gameObject.transform.position;      // �Ѿ� ���� ��ġ ������ ���.

            
           // boom = Instantiate(boom, boomPosition, Quaternion.identity);
       



            Destroy(collision.gameObject); //�� �Ҹ�
            Destroy(this.gameObject); //�Ѿ� �Ҹ� 

        }



    }
}
