using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
   
    public float radius=1f;

   

    
       
        
    void Update()
    {
      
        
        

        //Ű���� �Է��� �޴� �ڵ�
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

        // �÷��̾ ȭ��ۿ� �������� �ϱ�
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
