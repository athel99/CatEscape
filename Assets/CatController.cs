using System.Collections;
using System.Collections.Generic;
using TMPro.EditorUtilities;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CatController : MonoBehaviour
{
    [SerializeField] private Rigidbody2D rbody;
    [SerializeField] private float jumpforce = 680f;
    [SerializeField] private float moveforce = 0.003f;
    [SerializeField] private CloudGamedirector gameDirector;
    private Animator anim;
    private bool isjump= false;


    private void Start()
    {
        anim =GetComponent<Animator>();
               

        //this.gameDirector = GameObject.Find("GameObject").GetComponent<CloudGameDirector>();
        //this.gameDirector = GameObject.FindAnyObjectByType<CloudGameDirector>();
    }
    void Update()
    {
        
        //����
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (isjump==false)
            {
                isjump = true;
                this.rbody.AddForce(this.transform.up * this.jumpforce);//ȸ�������� ��
                
            }

                   
           

            //this.rbody.AddForce(Vector3.up * this.force); //�������θ� ��
            //���� ĳ������ y������ ���ư��� �Ʒ��� ������ y��������� ���ư���.
        }

       
        //Ű�� ������ �ִ� ���ȿ� �¿��̵�
        int dirX =0; // ���� ���� 0 ������ 1 ���� -1 
        


        if (Input.GetKey(KeyCode.RightArrow)) 
        {
            dirX = 1;   
        }

        if (Input.GetKey(KeyCode.LeftArrow)) 
        { 
            dirX = -1;        
        }

        

        if (dirX!= 0)
        {
            this.transform.localScale = new Vector3(dirX, 1, 1);
        }


        // Debug.Log(dir); //����

        //�ӵ��� �������� 


        if (Mathf.Abs(this.rbody.velocity.x) < 3)
        {
            this.rbody.AddForce(this.transform.right * dirX * moveforce);
        }
        
        
        // �÷��̾� �̵��ӵ��� ���� �ִϸ��̼� �ӵ��� ��������.
        // this.anim.speed = (Mathf.Abs(this.rbody.velocity.x) / 2f);
       

        this.gameDirector.UpdateVelocityText(this.rbody.velocity);

        //ȭ�� ������ �������� �ϱ�
        float clamf = Mathf.Clamp(this.transform.position.x, -2.4f, 2.5f);
        Vector3 pos = this.transform.position;
        pos.x = clamf;
        this.transform.position = pos;


    }


    void OnCollisionEnter2D(Collision2D col) 
    { 
         isjump = false;  
    }

    //�浹 ���� Ʈ���Ÿ���� ��� 
    private void OnTriggerEnter2D(Collider2D collision) //�����浹�Ҷ� �ѹ��� 
    {
        //�����ȯ
        Debug.LogFormat("�浹");
        SceneManager.LoadScene("CloudClear");



    }
   
}
