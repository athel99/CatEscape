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
    private float timeLeft = 30f; //���ѽð� 30��

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

            this.scoreText.text = string.Format("���� {0}",basketController.score);
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

            string minutes = Mathf.Floor(timeLeft / 60).ToString("00"); //Mathf.Floor �Լ��� ����Ͽ� �Ҽ��� ���ϸ� ����
            string seconds = Mathf.Floor(timeLeft % 60).ToString("00");
            this.timeText.text = "�����ð� " + minutes + ":" + seconds;

           

        }


    }

    void ChangeScene()
    {
        Debug.LogFormat("{0}{1}{2}",gameData.score,gameData.apple,gameData.bomb);
        // ���������� ��ȯ
        SceneManager.LoadScene("AppleEnd");

    }

}
