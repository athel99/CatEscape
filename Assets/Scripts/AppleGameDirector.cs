using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Linq;
using UnityEngine.XR;
using UnityEngine.SceneManagement;

public class AppleGameDirector : MonoBehaviour
{
    [SerializeField] private GameObject basket;
    [SerializeField] private GameObject score;
    [SerializeField] private GameObject time;


    [SerializeField] private GameData gameData;
    

    
    private Text scoreText;
    private Text timeText;
    private float done = 10f; //���ѽð�

    void Start()
    {

        scoreText = this.score.GetComponent<Text>();
        timeText = this.time.GetComponent<Text>();

        Invoke("ChangeScene", 10f);
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

            this.scoreText.text = string.Format("���� {0}", basketController.score);


        };

    }

    public void TimeAttack()
    {


        if (this.done > 0f)
        {

            this.done -= Time.deltaTime;

           this.timeText.text = string.Format("�����ð� {0:0.00}",this.done);

        }

       
    }

    void ChangeScene()
    {
        
            // ���������� ��ȯ
            SceneManager.LoadScene("AppleEnd");
       
    }





}