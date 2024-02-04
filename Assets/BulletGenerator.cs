using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletGenerator : MonoBehaviour
{
    [SerializeField] private GameObject bulletPrefab;
    [SerializeField] private GameObject bulletPrefab2;


    public GameObject CreateBullet()
    {
        return Instantiate(this.bulletPrefab);
    }
    public GameObject CreateBullet2()
    {
        return Instantiate(this.bulletPrefab2);
    }


}