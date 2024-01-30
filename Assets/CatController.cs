using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatController : MonoBehaviour
{
    [SerializeField] private Rigidbody2D rbody;
    [SerializeField] private float force = 680f;
    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        //점프
        {
            this.rbody.AddForce(this.transform.up * this.force);//회전방향대로 업
            //this.rbody.AddForce(Vector3.up * this.force); //직선위로만 업
              }

        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            this.rbody.AddForce(Vector3.left*this.force);

        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            this.rbody.AddForce(Vector3.right*this.force);

        }


    }
}
