using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponBullet : MonoBehaviour
{
    public Transform firePoint; //�Ѿ� �߻� ��ġ
    public GameObject bulletprefab; // �Ѿ� ������
   


   
   

   
    void Update()
    {
        firePoint = this.transform;

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(bulletprefab,firePoint.position,firePoint.rotation);
        }
    }
}
