using System.Collections;
using System.Collections.Generic;
using TMPro.EditorUtilities;
using UnityEngine;

public class CatController : MonoBehaviour
{
    [SerializeField] private Rigidbody2D rbody;
    [SerializeField] private float jumpforce = 680f;
    [SerializeField] private float moveforce = 0.003f;
    [SerializeField] private CloudGamedirector gameDirector;

    private void Start()
    {
        //this.gameDirector = GameObject.Find("GameDirector").GetComponent<ClimbCloudGameDirector>();
        //this.gameDirector = GameObject.FindAnyObjectByType<ClimbCloudGameDirector>();
    }
    void Update()
    {
        
        //점프
        if (Input.GetKeyDown(KeyCode.Space))
        {
            this.rbody.AddForce(this.transform.up * this.jumpforce);//회전방향대로 업
            //this.rbody.AddForce(Vector3.up * this.force); //직선위로만 업
            //위는 캐릭터의 y축으로 날아가고 아래는 세계의 y축방향으로 날아간다.
        }
        
        

        //키를 누르고 있는 동안에 좌우이동
        int dirX =0;
        


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
             
               
        // Gamedirector
        this.gameDirector.UpdateVelocityText(this.rbody.velocity);



    }
}
