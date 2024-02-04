using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceEnemyGenerator : MonoBehaviour
{
    public GameObject enemyPrefab;
    private float delta;    //경과된 시간 변수 
    public GameObject player;

    void Update()
    {
        delta += Time.deltaTime;  //이전 프레임과 현재 프레임 사이 시간 
        
        if (delta > 2)  //3초보다 크다면 
        {
            //생성 
            GameObject go = UnityEngine.Object.Instantiate(this.enemyPrefab);
            //위치 재 설정 
            float randX = UnityEngine.Random.Range(-2.5f, 2.5f);
            float randY = UnityEngine.Random.Range(player.transform.position.y+3f, player.transform.position.y + 7f);


            go.transform.position
                = new Vector3(randX, randY, go.transform.position.z);

            delta = 0;  //경과 시간을 초기화 
        }
    }

   

}
