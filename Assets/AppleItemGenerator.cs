using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppleItemGenerator : MonoBehaviour
{
    [SerializeField] GameObject apple;
    [SerializeField] GameObject bomb;
    private float delta;
    void Update()
    {
        delta += Time.deltaTime;
        if (delta > 1)
        {
            delta = 0;
            GameObject item;    //게임오브젝트 apple, bomb
            int dice = Random.Range(1, 3);  //1 ~ 2 사이 랜덤값
            if (dice == 1)
            {
                item = Instantiate(apple);  // 1이 나왔을때 apple을 생성한다
            }
            else
            {
                item = Instantiate(bomb);   // 나머지일때 bomb을 생성한다.
            }
            float x = Random.Range(-1, 1);  // 랜덤한 x축의 범위
            float z = Random.Range(-1, 1);  // 랜덤한 z축의 범위
            item.transform.position = new Vector3(x, 3, z);
        }

    }

}
