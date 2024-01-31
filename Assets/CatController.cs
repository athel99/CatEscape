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
        
        //점프
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (isjump==false)
            {
                isjump = true;
                this.rbody.AddForce(this.transform.up * this.jumpforce);//회전방향대로 업
                
            }

                   
           

            //this.rbody.AddForce(Vector3.up * this.force); //직선위로만 업
            //위는 캐릭터의 y축으로 날아가고 아래는 세계의 y축방향으로 날아간다.
        }

       
        //키를 누르고 있는 동안에 좌우이동
        int dirX =0; // 방향 멈춤 0 오른쪽 1 왼쪽 -1 
        


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


        // Debug.Log(dir); //방향

        //속도를 제한하자 


        if (Mathf.Abs(this.rbody.velocity.x) < 3)
        {
            this.rbody.AddForce(this.transform.right * dirX * moveforce);
        }
        
        
        // 플레이어 이동속도에 따라 애니메이션 속도를 조절하자.
        // this.anim.speed = (Mathf.Abs(this.rbody.velocity.x) / 2f);
       

        this.gameDirector.UpdateVelocityText(this.rbody.velocity);

        //화면 밖으로 못나가게 하기
        float clamf = Mathf.Clamp(this.transform.position.x, -2.4f, 2.5f);
        Vector3 pos = this.transform.position;
        pos.x = clamf;
        this.transform.position = pos;


    }


    void OnCollisionEnter2D(Collision2D col) 
    { 
         isjump = false;  
    }

    //충돌 판정 트리거모드일 경우 
    private void OnTriggerEnter2D(Collider2D collision) //최초충돌할때 한번만 
    {
        //장면전환
        Debug.LogFormat("충돌");
        SceneManager.LoadScene("CloudClear");



    }
   
}
