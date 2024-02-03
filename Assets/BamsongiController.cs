using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BamsongiController : MonoBehaviour
{
    private Rigidbody rbody;
    private ParticleSystem particle;
    public Vector3 direct;
    void Start()
    {
        this.rbody = this.GetComponent<Rigidbody>();
        this.particle = this.GetComponent<ParticleSystem>();  
        this.Shoot();
    }

    void OnCollisionEnter(Collision collision)
    {
        Debug.LogFormat("OnCollisionEnter: {0}", collision.gameObject.name);
        this.rbody.isKinematic = true;
        this.GetComponent<ParticleSystem>().Play();


    }

    public void Shoot()
    {
        this.rbody.AddForce(-direct * 2000);
    }
}
