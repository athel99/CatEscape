using System;
using System.Collections;
using System.Collections.Generic;
using System.Net;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class GameDerector : MonoBehaviour
{

    private GameObject carGo;
    private GameObject flagGo;
    private GameObject distanceGo;
    private Text distanceText;
    

    // Start is called before the first frame update
    void Start()
    {
        this.carGo = GameObject.Find("car");
        Debug.Log("this.carGo:{0}",this.carGo);
        this.flagGo= GameObject.Find("flag");
        Debug.Log("this.flag:{0}", this.flagGo);
        this.distanceGo = GameObject.Find("distance");
        //Debug.Log("this.flag:{0}", this.flagGo);

        distanceText =this.distanceGo.GetComponent<Text>();

    

    }

    // Update is called once per frame
    void Update()
    {
        float length = this.flagGo.transform.position.x - this.carGo.transform.position.x;

        distanceText.text = "남은거리:" + length.ToString("0") + "m";

          
    }
}
