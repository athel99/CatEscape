using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceEnemyController : MonoBehaviour
{
    [SerializeField] private float speed = 1f;
    
   

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

        

    }
}
