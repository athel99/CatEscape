using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class EnemyController : MonoBehaviour
{
    public enum State //�ִϸ��̼�
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


    void Start()
    {
        this.hp = this.maxHp; 
        Debug.LogFormat("{0}/{1}", this.hp, this.maxHp);
        this.gameDirector.UpdateHpText(this.hp, this.maxHp);
        this.SetState(State.Idle); // ���� ���� 
    }

   

    void Update()
    {
        //���콺�� Ŭ���ϸ� hp -1 �Ҹ�, �ؽ�Ʈ ǥ��, �ִ� Hit ��ȯ
        if(Input.GetMouseButtonDown(0))
        {
            this.hp -= 1;
            if (this.hp <= 0)
            {
                this.hp = 0;
            }
            this.gameDirector.UpdateHpText(this. hp, this.maxHp);
            this.SetState(State.Hit);
        }

        switch (this.state)
        {
            case State.Idle:
                break;
            case State.Hit:
                this.delta += Time.deltaTime;
                if (this.delta > this.hitAnimLength)
                {
                    this.delta = 0; 
                    if (this.hp <= 0) //hp�� 0���� ������
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
                this.delta = 0;
                if (this.delta > this.hitAnimLength)
                {   Destroy(this.gameObject);
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
}
