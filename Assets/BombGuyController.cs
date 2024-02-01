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
            //애니메이션 전환 하기 
            //전환 할때 파라미터에 값을 변경하기 
            this.anim.SetInteger("State", 0);
        }
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            Debug.Log("Run");
            this.anim.SetInteger("State", 1);
        }



        //화면밖으로 나가지않게 하기
        float clampX = Mathf.Clamp(this.rb.transform.position.x, -2.1f, 2.1f);
        Vector3 pos = this.rb.transform.position;
        pos.x = clampX;
        this.rb.transform.position = pos;






    }




}
