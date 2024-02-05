using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Linq;

public class AppleGameDirector : MonoBehaviour
{
    [SerializeField] private GameObject basket;
    [SerializeField] private GameObject score;

    [SerializeField] private GameData gameData;
    

    private float delta;
    private Text scoreText;

    void Start()
    {

        scoreText = this.score.GetComponent<Text>();

    }


    void Update()
    {

       
        GetItem();

    }

   
    public void GetItem()
    {
        BasketController basketController = basket.GetComponent<BasketController>();
        basketController.onHit = () =>
        {
            GameData gameData = this.gameData;

            this.scoreText.text = string.Format("Á¡¼ö {0}", basketController.score);


        };

    }


}
