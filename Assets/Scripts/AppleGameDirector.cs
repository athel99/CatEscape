using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Linq;
using UnityEngine.XR;
using UnityEngine.SceneManagement;
using System;

public class AppleGameDirector : MonoBehaviour
{
    [SerializeField] private GameObject basket;
    [SerializeField] private GameObject score;
    [SerializeField] private GameObject time;


    [SerializeField] private GameData gameData;
    
   
    
    private Text scoreText;
    private Text timeText;
    private float done = 10f; //제한시간

    void Start()
    {

        scoreText = this.score.GetComponent<Text>();
        timeText = this.time.GetComponent<Text>();

        this.NextDoor();

        Invoke("ChangeScene", 10f);
    }

    private void NextDoor()
    {
        GameObject basketGo = this.basket;
        BasketController basketController = basketGo.GetComponent<BasketController>();
        basketController.onHit = () =>
        {
            this.gameData.UpdateData(basketController.score, basketController.apple,basketController.bomb);
        };
    }

    void Update()
    {

       
        GetItem();
        TimeAttack();
       
    }

   
    public void GetItem()
    {
        BasketController basketController = basket.GetComponent<BasketController>();
        basketController.onHit = () =>
        {
            GameData gameData = this.gameData;

            this.scoreText.text = string.Format("점수 {0}", basketController.score);


        };

    }

    public void TimeAttack()
    {


        if (this.done > 0f)
        {

            this.done -= Time.deltaTime;

           this.timeText.text = string.Format("남은시간 {0:0.00}",this.done);

        }

       
    }

    void ChangeScene()
    {
        
            // 엔딩씬으로 전환
            SceneManager.LoadScene("AppleEnd");
       
    }





}
