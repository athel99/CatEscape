using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class BombGuyController : MonoBehaviour
{
       
    [SerializeField] private Animator anim;
    [SerializeField] Rigidbody2D rb;
    [SerializeField] private float moveforce=10f;
    
   
    private void Start()
    {
       
    }


    
    void Update()
    {
        //�̵����� �ƴ϶�� Idle �ִϸ��̼� ����
        this.anim.SetInteger("State", 0);
       
       
        int dirX = 0; //����
       if(Input.GetKey(KeyCode.RightArrow)) //������ �̵�
        {
            dirX = 1;

        }
        if (Input.GetKey(KeyCode.LeftArrow)) //���� �̵�
        {
            dirX = -1;

        }
        if (dirX != 0) // �̵����̶��
        {            
           this.rb.transform.localScale= new Vector3(dirX,1,1); // ���⿡ ���� �ٶ󺸴� ��ġ ����
            this.anim.SetInteger("State", 1); // Run �ִϸ��̼� ����
        }


       
        this.rb.AddForce(this.transform.right * dirX * moveforce); 

        
     
        //ȭ������� �������ʰ� �ϱ�
        float clampX = Mathf.Clamp(this.rb.transform.position.x, -2.1f, 2.1f);
        Vector3 pos = this.rb.transform.position;
        pos.x = clampX;
        this.rb.transform.position = pos;


    }


}
