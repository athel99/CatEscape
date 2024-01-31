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

        //고양이 y좌표 이동에 따라 카메라도 y 좌표 변동

        if (this.player.transform.position.y> -6f)
        {
            Vector3 playerGo = this.player.transform.position;
             transform.position
                = new Vector3(transform.position.x, playerGo.y, transform.position.z);

            

        }




    }
}
