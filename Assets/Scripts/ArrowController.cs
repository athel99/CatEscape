using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class ArrowController : MonoBehaviour
{
    [SerializeField] private float speed=1f;
    [SerializeField] private float radius=0.5f;
   
        
    private CatEscapeGameDerector gameDerector;

    private GameObject playerGo;

   

    void Start()
    {
        //이름으로 게임오브젝트를 찾는다 
        this.playerGo = GameObject.Find("player");
        //타입으로 컴포넌트를 찾는다 
        this.gameDerector = GameObject.FindObjectOfType<CatEscapeGameDerector>();


    }

    
    void Update()
    {
       Vector3 movement = Vector3.down *speed *Time.deltaTime;  //방향 * 속도 * 시간 
        this.transform.Translate(movement);
        //Debug.LogFormat("y:{0}", this.transform.position.y);

        // 화살이 바닥에 닿으면 사라짐
        if(this.transform.position.y <= -3.32f)
        {
            //Debug.LogError("remove");
            Destroy(this.gameObject ); //씬에서 제거
            //Destroy(this) ; arrowcontroller가 제거됌!
           

        }

        //플레이어와 화살의 거리 구하기 
        Vector2 p1=this.transform.position;
        Vector2 p2=this.playerGo.transform.position;
        Vector2 dir =p1- p2;//방향
        float distance = dir.magnitude;//거리


        //충돌거리 구하기
        float r1 = this.radius;
        PlayerController controller=this.playerGo.GetComponent<PlayerController>();
        float r2 = controller.radius;
        float sumRadius = r1 + r2;

        if (distance < sumRadius)//충돌할 경우
        {
            Debug.LogFormat("충돌 {0} {1}",distance,sumRadius);// {}공간 에러!! 
            Destroy(this.gameObject);

           

            //hp 감소
            this.gameDerector.DescreaseHP();


        }

        
        


    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(this.transform.position, this.radius);
            
    }

}
