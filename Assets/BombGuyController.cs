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
        int dirX = 0;
       if(Input.GetKey(KeyCode.RightArrow))
        {
            dirX = 1;

        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            dirX = -1;

        }
        if (dirX != 0)
        {
           this.rb.transform.localScale= new Vector3(dirX,1,1);
        }
        
        this.rb.AddForce(this.transform.right * dirX * moveforce);

        

        if (Input.GetKeyDown(KeyCode.Alpha0))
        {
           Debug.Log("Idle");
            //�ִϸ��̼� ��ȯ �ϱ� 
            //��ȯ �Ҷ� �Ķ���Ϳ� ���� �����ϱ� 
            this.anim.SetInteger("State", 0);
        }
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            Debug.Log("Run");
            this.anim.SetInteger("State", 1);
        }



        //ȭ������� �������ʰ� �ϱ�
        float clampX = Mathf.Clamp(this.rb.transform.position.x, -2.1f, 2.1f);
        Vector3 pos = this.rb.transform.position;
        pos.x = clampX;
        this.rb.transform.position = pos;






    }




}
