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
        //이동중이 아니라면 Idle 애니메이션 실행
        this.anim.SetInteger("State", 0);
       
       
        int dirX = 0; //방향
       if(Input.GetKey(KeyCode.RightArrow)) //오른쪽 이동
        {
            dirX = 1;

        }
        if (Input.GetKey(KeyCode.LeftArrow)) //왼쪽 이동
        {
            dirX = -1;

        }
        if (dirX != 0) // 이동중이라면
        {            
           this.rb.transform.localScale= new Vector3(dirX,1,1); // 방향에 따라 바라보는 위치 변경
            this.anim.SetInteger("State", 1); // Run 애니메이션 실행
        }


       
        this.rb.AddForce(this.transform.right * dirX * moveforce); 

        
     
        //화면밖으로 나가지않게 하기
        float clampX = Mathf.Clamp(this.rb.transform.position.x, -2.1f, 2.1f);
        Vector3 pos = this.rb.transform.position;
        pos.x = clampX;
        this.rb.transform.position = pos;


    }


}
