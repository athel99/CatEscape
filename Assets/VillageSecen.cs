using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VillageSecen : MonoBehaviour
{
    private HeroDataManager heroDataManager;
    private int hp;
    private int maxHp;
    public Text textHp;

    void Start()
    {
        this.heroDataManager = GameObject.FindFirstObjectByType<HeroDataManager>();

        this.hp = this.heroDataManager.heroHp;
        this.maxHp = this.heroDataManager.heroMaxHp;
    }

    // Update is called once per frame
    void Update()
    {
            this.textHp.text = string.Format("{0}/{1}",this.hp,this.maxHp);


    }
}
