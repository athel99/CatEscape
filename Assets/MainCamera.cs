using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainCamera : MonoBehaviour
{
    GameObject player;



    
    void Start()
    {
        this.player = GameObject.Find("SpaceShip");

    }

    
    void Update()
    {

        //���ּ� y��ǥ �̵��� ���� ī�޶� y ��ǥ ����

        if (this.player.transform.position.y > 5f)
        {
            Vector3 playerGo = this.player.transform.position;
            transform.position
               = new Vector3(transform.position.x, playerGo.y, transform.position.z);

        }

        if(this.player.transform.position.y > 25f)
        {
            transform.position = new Vector3(transform.position.x,26f,transform.position.z);
        }


    }
}
