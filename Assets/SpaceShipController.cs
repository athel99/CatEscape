using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceShipController : MonoBehaviour
{
    public enum State 
        {
        Center, Left, Right
    }
    public float moveSpeed=0.5f;
    public Rigidbody2D rb;
   
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        
    }

    void MoveControl()
    {
        float moveX = moveSpeed * Time.deltaTime * Input.GetAxis("Horizontal");
        float moveY = moveSpeed * Time.deltaTime * Input.GetAxis("Vertical");
        transform.Translate(moveX,moveY,0);

    }



    void Update()
    {
        MoveControl();

        InCamera();
       
    }

    void InCamera()
    {
        //화면밖으로 나가지않게 하기
        float clampX = Mathf.Clamp(this.rb.transform.position.x, -2.1f, 2.1f);
        Vector3 pos = this.rb.transform.position;
        pos.x = clampX;
        this.rb.transform.position = pos;

    }
}
