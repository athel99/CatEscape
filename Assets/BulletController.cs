using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class BulletController : MonoBehaviour
{
    public float speed=4f;

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

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //���̶� �浹�ϸ� �����

        if (collision.tag == "Enemy") //�±� ���� 
        {
            Destroy(collision.gameObject); //�� �Ҹ�
            Destroy(this.gameObject); //�Ѿ� �Ҹ� 

        }



    }
}
