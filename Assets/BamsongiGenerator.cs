using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class BamsongiGenerator : MonoBehaviour
{
    [SerializeField] GameObject bamsngiprefab;
    public Rigidbody bamgo;

    
    void Start()
    {
        this.bamgo = GetComponent<Rigidbody>();


    }

   
    void Update()
    {
         //ȭ���� ��ġ�ϸ� ���콺 ��ġ

        if (Input.GetMouseButtonDown(0))
        {
          //  Debug.Log(Input.mousePosition);

            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            // Debug.Log(ray);


            //Vector3 rayvector = new Vector3(ray.directon.x,ray.direction.y,ray.direction.z);

          //  DrawArrow.ForDebug(ray.origin, ray.direction, 10, Color.red, ArrowType.Solid);

              GameObject bam = UnityEngine.Object.Instantiate(this.bamsngiprefab);

            //this.bamgo.Addforce(ray.direction,100f);
                






        }
    }
}
