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


        // 위로 총알 발사
        this.transform.Translate(Vector2.up * this.speed * Time.deltaTime);

        //화면 밖으로 나가면 사라지게
        if (this.transform.position.y > 6.56f)
        {
            Destroy(this.gameObject);
        }


    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
      
       
        //적이랑 충돌하면 사라짐

        if (collision.tag == "Enemy") //태그 설정 
        {
           // this.boomPosition = this.gameObject.transform.position;      // 총알 현재 위치 변수에 담기.

            
           // boom = Instantiate(boom, boomPosition, Quaternion.identity);
       



            Destroy(collision.gameObject); //적 소멸
            Destroy(this.gameObject); //총알 소멸 

        }



    }
}
