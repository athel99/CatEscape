using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletGenerator : MonoBehaviour
{
    public GameObject bullet;
  
    private float delta;
   

    private void Start()
    {
       

    }

    void Update()
    {



        delta += Time.deltaTime;  //이전 프레임과 현재 프레임 사이 시간 

        if (delta > 3)  //3초보다 크다면 
        {
            //생성 
            GameObject go = UnityEngine.Object.Instantiate(this.bullet);
            //위치 재 설정 
          go.transform.position = new Vector3(0, 0, 0);


            delta = 0;  //경과 시간을 초기화 
        }
    }
    
}
