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

        //우주선 y좌표 이동에 따라 카메라도 y 좌표 변동

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
