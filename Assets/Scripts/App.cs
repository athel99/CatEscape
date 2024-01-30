using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class App : MonoBehaviour
{
    [SerializeField] private Transform b; //child

    private void Start()
    {
        Debug.LogFormat("b.positon:{0}", b.position);
        Debug.LogFormat("b.localpositon:{0}", b.localPosition);



    }




}
