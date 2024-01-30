using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarController : MonoBehaviour
{
    

    [SerializeField]
    private float attenuation = 0.996f;

    [SerializeField]
    private float divided  = 1600;



    private float speed = 0;
    private Vector3 startPosition;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            
            this.startPosition = Input.mousePosition;

            //    speed = maxspeed;
        }


        else if (Input.GetMouseButtonUp(0))
        {
            
            
            float length =
                Input.mousePosition.x - this.startPosition.x;
            Debug.Log(length);
            Debug.Log(length/divided);

            speed = length / divided;
            Debug.LogFormat("<Color=yellow>speed: {0}</color>", speed);

           AudioSource audioSource= this.gameObject.GetComponent<AudioSource>();
            audioSource.Play();


        }

        this.gameObject.transform.Translate(new Vector3(speed,0,0));

        speed *= attenuation;


    }
}
