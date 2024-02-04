using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceEnemyGenerator : MonoBehaviour
{
    public GameObject enemyPrefab;
    private float delta;    //����� �ð� ���� 
    public GameObject player;

    void Update()
    {
        delta += Time.deltaTime;  //���� �����Ӱ� ���� ������ ���� �ð� 
        
        if (delta > 2)  //3�ʺ��� ũ�ٸ� 
        {
            //���� 
            GameObject go = UnityEngine.Object.Instantiate(this.enemyPrefab);
            //��ġ �� ���� 
            float randX = UnityEngine.Random.Range(-2.5f, 2.5f);
            float randY = UnityEngine.Random.Range(player.transform.position.y+3f, player.transform.position.y + 7f);


            go.transform.position
                = new Vector3(randX, randY, go.transform.position.z);

            delta = 0;  //��� �ð��� �ʱ�ȭ 
        }
    }

   

}
