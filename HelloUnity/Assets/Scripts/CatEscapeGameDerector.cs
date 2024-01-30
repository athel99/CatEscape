using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CatEscapeGameDerector : MonoBehaviour
{

    [SerializeField] private Image hpGauge;
   

    public void DescreaseHP()
    {
      



        this.hpGauge.fillAmount -= 0.1f;

        

                      
    }
   
}
