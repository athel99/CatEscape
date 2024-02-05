using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceEnemyController : MonoBehaviour
{
    [SerializeField] private float speed = 1f;
    
   

    private GameObject playerGo;

    private void Start()
    {
        //이름으로 게임오브젝트를 찾는다 
        this.playerGo = GameObject.Find("SpaceShip");

       
    }

    void Update()
    {
        //방향 * 속도 * 시간 
        Vector3 movement = Vector3.down * speed * Time.deltaTime;
        this.transform.Translate(movement);
       

        //현재 y 좌표가 2.93보다 작아졌을때 씬에서 제거한다 
        if (this.transform.position.y <= -5f)
        {
            
            Destroy(this.gameObject);   //게임오브젝트를 씬에서 제거 
        }

        

    }
}
