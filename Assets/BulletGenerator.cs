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



        delta += Time.deltaTime;  //���� �����Ӱ� ���� ������ ���� �ð� 

        if (delta > 3)  //3�ʺ��� ũ�ٸ� 
        {
            //���� 
            GameObject go = UnityEngine.Object.Instantiate(this.bullet);
            //��ġ �� ���� 
          go.transform.position = new Vector3(0, 0, 0);


            delta = 0;  //��� �ð��� �ʱ�ȭ 
        }
    }
    
}
