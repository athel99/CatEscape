using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroController : MonoBehaviour
{
    private HeroDataManager heroDataManager; //��������� 
    //private int maxhp;

    //public int hp;
    public int Hp { get; set; } //�Ӽ� ; �ܺ� ���� ���� = this.hp 
    public int MaxHp { get; set; } //�Ӽ� ; �ܺ� ���� ���� = this.hp 

    // Start is called before the first frame update
    public System.Action onHit; //�븮�� 


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
            this.onHit(); //�븮�� ȣ�� 
           
        }
    }
}
