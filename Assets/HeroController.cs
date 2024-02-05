using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroController : MonoBehaviour
{
    private HeroDataManager heroDataManager; //게임저장소 
    //private int maxhp;

    //public int hp;
    public int Hp { get; set; } //속성 ; 외부 접근 가능 = this.hp 
    public int MaxHp { get; set; } //속성 ; 외부 접근 가능 = this.hp 

    // Start is called before the first frame update
    public System.Action onHit; //대리자 


    void Start()
    {
        this.MaxHp = 10;
        this.Hp = this.MaxHp;

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            this.Hp -=1;
            if( this.Hp <= 0 ){
                this.Hp = 0;
            }
            this.onHit(); //대리자 호출 
           
        }
    }
}
