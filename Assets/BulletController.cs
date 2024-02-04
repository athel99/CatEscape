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


        // 위로 총알 발사
        this.transform.Translate(Vector2.up * this.speed * Time.deltaTime);

        //화면 밖으로 나가면 사라지게
        if (this.transform.position.y >6.56f)
        {
            Destroy(this.gameObject);
        }


    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
      
       
        //적이랑 충돌하면 사라짐

        if (collision.tag == "Enemy") //태그 설정 
        {
            
            Destroy(collision.gameObject); //적 소멸
            Destroy(this.gameObject); //총알 소멸 
            //폭발 프리팹 설정
              Instantiate(explosion,this.transform.position, Quaternion.identity);
           
             int temp = UnityEngine.Random.Range(0, 3);
            Instantiate(item[temp], this.transform.position, Quaternion.identity);

        }

       

    }
}
