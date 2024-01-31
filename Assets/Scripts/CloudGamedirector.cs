using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class CloudGamedirector : MonoBehaviour
{
    [SerializeField] private Text velocityText;


    public void UpdateVelocityText(Vector2 velocity)
    {
        //플레이어의 속도
        float velocityX = Mathf.Abs(velocity.x);
        this.velocityText.text = velocityX.ToString();
      
    }

    
}
