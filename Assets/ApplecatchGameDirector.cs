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
    private float done = 10f; //제한시간

    void Start()
    {

        

        this.NextDoor();

        Invoke("ChangeScene", 10f);
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


        if (this.done > 0f)
        {

            this.done -= Time.deltaTime;

            this.timeText.text = string.Format("남은시간 {0:0.00}", this.done);

        }


    }

    void ChangeScene()
    {
        Debug.LogFormat("{0}{1}{2}",gameData.score,gameData.apple,gameData.bomb);
        // 엔딩씬으로 전환
        SceneManager.LoadScene("AppleEnd");

    }

}
