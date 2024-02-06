using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ApplecatchGameDirector : MonoBehaviour
{
    [SerializeField] private GameObject basket;
   


    [SerializeField] private GameData gameData;



    [SerializeField] private Text scoreText;
    [SerializeField] private Text timeText;
    private float timeLeft = 30f; //제한시간 30초

    void Start()
    {

        

        this.NextDoor();

        Invoke("ChangeScene",this.timeLeft);
    }

    private void NextDoor()
    {
        GameObject basketGo = this.basket;
        BasketController basketController = basketGo.GetComponent<BasketController>();
        basketController.onHit = () =>
        {
            this.gameData.UpdateData(basketController.score, basketController.apple, basketController.bomb);

            this.scoreText.text = string.Format("점수 {0}",basketController.score);
        };
    }

    void Update()
    {


        TimeAttack();

    }


  

    public void TimeAttack()
    {


        if (this.timeLeft > 0f)
        {

            this.timeLeft -= Time.deltaTime;

            string minutes = Mathf.Floor(timeLeft / 60).ToString("00"); //Mathf.Floor 함수를 사용하여 소수점 이하를 버림
            string seconds = Mathf.Floor(timeLeft % 60).ToString("00");
            this.timeText.text = "남은시간 " + minutes + ":" + seconds;

           

        }


    }

    void ChangeScene()
    {
        Debug.LogFormat("{0}{1}{2}",gameData.score,gameData.apple,gameData.bomb);
        // 엔딩씬으로 전환
        SceneManager.LoadScene("AppleEnd");

    }

}
