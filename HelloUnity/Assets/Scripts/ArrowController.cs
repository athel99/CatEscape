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
        //�̸����� ���ӿ�����Ʈ�� ã�´� 
        this.playerGo = GameObject.Find("player");
        //Ÿ������ ������Ʈ�� ã�´� 
        this.gameDerector = GameObject.FindObjectOfType<CatEscapeGameDerector>();


    }

    
    void Update()
    {
       Vector3 movement = Vector3.down *speed *Time.deltaTime;  //���� * �ӵ� * �ð� 
        this.transform.Translate(movement);
        //Debug.LogFormat("y:{0}", this.transform.position.y);

        // ȭ���� �ٴڿ� ������ �����
        if(this.transform.position.y <= -3.32f)
        {
            //Debug.LogError("remove");
            Destroy(this.gameObject ); //������ ����
            //Destroy(this) ; arrowcontroller�� ���ŉ�!
           

        }

        //�÷��̾�� ȭ���� �Ÿ� ���ϱ� 
        Vector2 p1=this.transform.position;
        Vector2 p2=this.playerGo.transform.position;
        Vector2 dir =p1- p2;//����
        float distance = dir.magnitude;//�Ÿ�


        //�浹�Ÿ� ���ϱ�
        float r1 = this.radius;
        PlayerController controller=this.playerGo.GetComponent<PlayerController>();
        float r2 = controller.radius;
        float sumRadius = r1 + r2;

        if (distance < sumRadius)//�浹�� ���
        {
            Debug.LogFormat("�浹 {0} {1}",distance,sumRadius);// {}���� ����!! 
            Destroy(this.gameObject);

           

            //hp ����
            this.gameDerector.DescreaseHP();


        }

        
        


    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(this.transform.position, this.radius);
            
    }

}
