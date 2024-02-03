using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class BombGuyController : MonoBehaviour
{



  
    [SerializeField] private Animator anim;
     private Rigidbody2D rb;
    [SerializeField] private float moveforce=10f;
    public bool isHitting=false; // Hit 중인지

    private void Start()
    {
        this.rb = GetComponent<Rigidbody2D>();

    }

    
    void Update()
    {      
        Move();
        InCamera();
        Attack();
        HitEnd();


    }

    public void Attack()
    {
        if(Input.GetKey(KeyCode.Space))
        {
            isHitting = true; // Hit 상태로 변경
            this.anim.SetInteger("State", 2); //공격
           
        }
        
   

    }
    // Hit 애니메이션 종료 시 호출되는 함수
    public void HitEnd()
    {
        isHitting = false; // Hit 상태 해제
    }



    private void InCamera()
    {
        //화면밖으로 나가지않게 하기
        float clampX = Mathf.Clamp(this.rb.transform.position.x, -2.2f, 2.2f);
        Vector3 pos = this.rb.transform.position;
        pos.x = clampX;
        this.rb.transform.position = pos;
    }

    private void Move()
    {
            this.anim.SetInteger("State", 0);//이동중이 아니라면 Idle 애니메이션 실행
        
        int dirX = 0; //방향
        if (Input.GetKey(KeyCode.RightArrow)) //오른쪽 이동
        {
            dirX = 1;

        }
        if (Input.GetKey(KeyCode.LeftArrow)) //왼쪽 이동
        {
            dirX = -1;

        }
        if (dirX != 0) // 이동중이라면
        {
            this.rb.transform.localScale = new Vector3(dirX, 1, 1); // 방향에 따라 바라보는 위치 변경
            this.anim.SetInteger("State", 1); // Run 애니메이션 실행
        }

        this.rb.AddForce(this.transform.right * dirX * moveforce);

    }
    


}
