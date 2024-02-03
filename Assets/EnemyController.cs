using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class EnemyController : MonoBehaviour
{
    public enum State //애니메이션
    {
        Idle, Hit, Dead
    }

    [SerializeField] private Animator anim;
    [SerializeField] private BombGameDirector gameDirector;
   

    private float hitAnimLength = 0.133f;
    private float dieAnimLength = 0.133f;

    private State state;
    private float delta = 0;
    private int maxHp = 2;
    private int hp;
    private Rigidbody2D rb;

    void Start()
    {
        this.rb = GetComponent<Rigidbody2D>();
        this.hp = this.maxHp; 
        Debug.LogFormat("{0}/{1}", this.hp, this.maxHp);
        this.gameDirector.UpdateHpText(this.hp, this.maxHp);
        this.SetState(State.Idle); // 시작 동작 
    }

   

    void Update()
    {
        

        switch (this.state)
        {
            case State.Idle:
                break;
            case State.Hit:
                this.delta += Time.deltaTime;
                if (this.delta > this.hitAnimLength)
                {
                    this.delta = 0; 
                    if (this.hp <= 0) //hp가 0보다 작으면
                    {
                        this.SetState(State.Dead);
                    }
                    else 
                    {
                        this.SetState(State.Idle);

                    }
                }
                break;

            case State.Dead:
                this.delta += Time.deltaTime;
                if (this.delta > this.dieAnimLength )
                {
                    this.delta = 0;
                    Destroy(this.gameObject);
                }
                
                break;
                
        }

        
        
    }

    private void SetState(State state)
    {
        if(this.state!= state)
        {
            this.state = state;
            this.anim.SetInteger("State",(int)this.state);
        }
    }

    //플레이어와 충돌하면 hp -1 소모, 텍스트 표시, 애니 Hit 전환

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            BombGuyController player = collision.gameObject.GetComponent<BombGuyController>(); // 플레이어 컴포넌트 가져오기
            if (player.isHitting) // 플레이어가 Hit 중이면
            {
                this.hp -= 1;

                if (this.hp <= 0)
                {
                    this.hp = 0;
                }
                this.gameDirector.UpdateHpText(this.hp, this.maxHp);
                this.SetState(State.Hit);
            }
        }
    }


  
}



