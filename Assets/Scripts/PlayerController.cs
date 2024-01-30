using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
   
    public float radius=1f;

   

    
       
        
    void Update()
    {
      
        
        

        //키보드 입력을 받는 코드
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            //Debug.Log("left move");
            transform.Translate(-2,0,0);

        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            //Debug.Log("right move");
            transform.Translate(2, 0, 0);

        }

        // 플레이어가 화면밖에 못나가게 하기
                float clampX =
            Mathf.Clamp(this.transform.position.x, -8, 8);
        Vector3 pos = this.transform.position;
        pos.x = clampX;
        this.transform.position = pos;



    }
    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(this.transform.position, this.radius);

    }

}
