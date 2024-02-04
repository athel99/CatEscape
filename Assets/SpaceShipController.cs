using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
public class SpaceShipController : MonoBehaviour
{
    public enum State 
        {
        Center, Left, Right
    }
    [SerializeField] private float Speed = 1f;
    [SerializeField] private Vector2 horizBoundary; //이동거리 제한
    [SerializeField] private Vector2 vertBoundary;
    [SerializeField] private BulletGenerator bulletGenerator; //프리팹가져오기
    [SerializeField] private Transform firePoint;

    private Rigidbody2D rb;

    


    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        
    }

    void Update()
    {
        MoveControl();

        InCamera();

        BulletFire();
    }
    void MoveControl()
    {
         float moveX = Input.GetAxisRaw("Horizontal");
        float moveY = Input.GetAxisRaw("Vertical");
        Vector3 dir = new Vector3(moveX, moveY, 0);
        this.transform.Translate(dir.normalized * this.Speed * Time.deltaTime);

    }



    void InCamera()
    {
        //화면밖으로 나가지않게 하기
        float clampX = Mathf.Clamp(this.rb.transform.position.x, this.horizBoundary.x, this.horizBoundary.y);
        float clampY = Mathf.Clamp(this.rb.transform.position.y, this.vertBoundary.x, this.vertBoundary.y);

        this.rb.transform.position = new Vector2(clampX, clampY);

    }
     void BulletFire()// 총알 발사하기
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GameObject bulletGo = this.bulletGenerator.CreateBullet();

            bulletGo.transform.position = this.firePoint.position;
        }
    }


   
}
