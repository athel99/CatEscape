using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private Button btnLeft;
    [SerializeField] private Button btnRight;

    public float radius=1f;


    private void Start()
    {
        //this.btnLeft.onClick.AddListener(this.LeftButtonClick); //대리자
        //this.btnRight.onClick.AddListener(this.RightButtonClick);

        this.btnLeft.onClick.AddListener(() => {   //람다 
           
        this.transform.Translate(-2,0,0);
                

        });
        this.btnRight.onClick.AddListener(() => {
            this.transform.Translate(2, 0, 0);

        });


    }



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


    public void LeftButtonClick()
    {
        //Debug.Log("왼쪽 버튼을 누르시오");
      //  this.transform.Translate(-2,0,0);

    }

    public void RightButtonClick()
    {
        //Debug.Log("오른쪽 버튼을 누르시오");
       // this.transform.Translate(2,0,0);


    }
}
