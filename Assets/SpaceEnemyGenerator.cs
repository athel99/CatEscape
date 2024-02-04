using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceEnemyGenerator : MonoBehaviour
{
    public GameObject enemyPrefab;
    private float delta;    //����� �ð� ���� 
   

    void Update()
    {
        delta += Time.deltaTime;  //���� �����Ӱ� ���� ������ ���� �ð� 
        
        if (delta > 3)  //3�ʺ��� ũ�ٸ� 
        {
            //���� 
            GameObject go = UnityEngine.Object.Instantiate(this.enemyPrefab);
            //��ġ �� ���� 
            float randX = UnityEngine.Random.Range(-2.5f, 2.5f);
            float randY = UnityEngine.Random.Range(4f, 6.5f);


            go.transform.position
                = new Vector3(randX, randY, go.transform.position.z);

            delta = 0;  //��� �ð��� �ʱ�ȭ 
        }
    }

   

}
