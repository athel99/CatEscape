using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponBullet : MonoBehaviour
{
    public Transform firePoint; //ÃÑ¾Ë ¹ß»ç À§Ä¡
    public GameObject bulletprefab; // ÃÑ¾Ë ÇÁ¸®ÆÕ
   


   
   

   
    void Update()
    {
        firePoint = this.transform;

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(bulletprefab,firePoint.position,firePoint.rotation);
        }
    }
}
