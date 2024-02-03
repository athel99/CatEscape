using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceEnemyController : MonoBehaviour
{
    [SerializeField] private float speed = 1f;
    [SerializeField] private float radius = 1f;

   

    private GameObject playerGo;

    private void Start()
    {
        //�̸����� ���ӿ�����Ʈ�� ã�´� 
        this.playerGo = GameObject.Find("SpaceShip");

       
    }

    void Update()
    {
        //���� * �ӵ� * �ð� 
        Vector3 movement = Vector3.down * speed * Time.deltaTime;
        this.transform.Translate(movement);
       

        //���� y ��ǥ�� 2.93���� �۾������� ������ �����Ѵ� 
        if (this.transform.position.y <= -5f)
        {
            
            Destroy(this.gameObject);   //���ӿ�����Ʈ�� ������ ���� 
        }

        //�Ÿ� 
        /*Vector2 p1 = this.transform.position;
        Vector2 p2 = this.playerGo.transform.position;
        Vector2 dir = p1 - p2;//���� 
        float distance = dir.magnitude; //�Ÿ� 
        //float distance = Vector2.Distance(p1, p2);

        float r1 = this.radius;
        PlayerController controller = this.playerGo.GetComponent<PlayerController>();
        float r2 = controller.radius;
        float sumRadius = r1 + r2;

        if (distance < sumRadius)   //�浹��
        {
          
            Destroy(this.playerGo);   //������ ���� 

          
        }*/

    }
}
