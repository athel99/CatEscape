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
    public bool isHitting=false; // Hit ������

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
            isHitting = true; // Hit ���·� ����
            this.anim.SetInteger("State", 2); //����
           
        }
        
   

    }
    // Hit �ִϸ��̼� ���� �� ȣ��Ǵ� �Լ�
    public void HitEnd()
    {
        isHitting = false; // Hit ���� ����
    }



    private void InCamera()
    {
        //ȭ������� �������ʰ� �ϱ�
        float clampX = Mathf.Clamp(this.rb.transform.position.x, -2.2f, 2.2f);
        Vector3 pos = this.rb.transform.position;
        pos.x = clampX;
        this.rb.transform.position = pos;
    }

    private void Move()
    {
            this.anim.SetInteger("State", 0);//�̵����� �ƴ϶�� Idle �ִϸ��̼� ����
        
        int dirX = 0; //����
        if (Input.GetKey(KeyCode.RightArrow)) //������ �̵�
        {
            dirX = 1;

        }
        if (Input.GetKey(KeyCode.LeftArrow)) //���� �̵�
        {
            dirX = -1;

        }
        if (dirX != 0) // �̵����̶��
        {
            this.rb.transform.localScale = new Vector3(dirX, 1, 1); // ���⿡ ���� �ٶ󺸴� ��ġ ����
            this.anim.SetInteger("State", 1); // Run �ִϸ��̼� ����
        }

        this.rb.AddForce(this.transform.right * dirX * moveforce);

    }
    


}
