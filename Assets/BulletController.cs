using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class BulletController : MonoBehaviour
{
    public float speed=4f;
    private Rigidbody2D rb;

    private void Start()
    {
        this.rb.velocity = transform.up*speed; //�Ѿ��� �������� �߻� 


    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Destroy(gameObject);

    }
}
