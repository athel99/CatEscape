using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NinjastarController : MonoBehaviour
{

    [SerializeField] private float rotateSpeed = 10f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        this.transform.Rotate(0, 0,rotateSpeed* Time.deltaTime);
        //방향 * 속도 * 시간
        this.transform.Translate(Vector3.up*1*Time.deltaTime,Space.World);





    }
}
