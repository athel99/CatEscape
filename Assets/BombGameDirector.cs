using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class BombGameDirector : MonoBehaviour
{
    [SerializeField] private Text hpText;
    private int maxHp=2;
    private int hp;


    public void UpdateHpText(int hp,int maxHp)
    {
        this.maxHp = maxHp;
        this.hp= this.maxHp;
       
        this.hpText.text="HP "+hp.ToString() +"/"+maxHp.ToString();

       

    }
}
