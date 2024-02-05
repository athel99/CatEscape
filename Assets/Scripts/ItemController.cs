using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemController : MonoBehaviour
{
    [SerializeField] float speed = 3f;    
   

    
    void Update()
    {
        this.transform.Translate(Vector3.down * speed*Time.deltaTime);
        
        //¹Ù´Ú¿¡ ´êÀ¸¸é Á¦°Å 
        if (this.transform.position.y<=0)
        {
            Destroy(this.gameObject);
        }
    }
}
