using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    GameObject player;
   


    // Start is called before the first frame update
    void Start()
    {
        this.player = GameObject.Find("cat");
       
    }

    // Update is called once per frame
    void Update()
    {

        //����� y��ǥ �̵��� ���� ī�޶� y ��ǥ ����

        if (this.player.transform.position.y> -6f)
        {
            Vector3 playerGo = this.player.transform.position;
             transform.position
                = new Vector3(transform.position.x, playerGo.y, transform.position.z);

            

        }




    }
}
