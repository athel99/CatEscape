using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;



public class ArrowGenerater : MonoBehaviour
{
   


    //프리팹 에셋을 가지고 프리팹 인스턴스를 만든다 
    [SerializeField] private GameObject arrowPrefab;
   

    private float delta; //경과된 시간
   


    void Update()
    {
       
            delta += Time.deltaTime; //이전과 현재 프레임사이의 시간
                                     //Debug.Log(delta);

            if (delta>3) //3초 간격으로 생성 
            {
                GameObject go = UnityEngine.Object.Instantiate(this.arrowPrefab);// 프리팹 생성 
                                                                                 //위치 재설정
                float ransX = UnityEngine.Random.Range(-8, 9); // x축 랜덤 생성 범위 
                go.transform.position
                    = new Vector3(ransX, go.transform.position.y, go.transform.position.z);

                delta = 0; //경과시간을 초기화 
            }
        
        




    }

   
    

}
