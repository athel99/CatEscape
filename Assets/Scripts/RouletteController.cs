using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RouletteController : MonoBehaviour
{

    [SerializeField]
    private float maxSpeed = 2;
    [SerializeField]
    private float attenuation = 1;
    

    private float speed =0;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       if(Input.GetMouseButtonDown(0))
        {
            speed = maxSpeed;
        } 
        
        this.transform.Rotate(0, 0, speed);


        speed *= attenuation;


        if (speed < 0.4)
        {
            speed = 0;
        }
        //Debug.Log(speed);

    }
}
