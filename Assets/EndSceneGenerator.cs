using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class EndSceneGenerator : MonoBehaviour
{
    private GameData gameData;
    private float apple;
    private float bomb;
    private float score;
    public Text textApple;
    public Text textBomb;
    public Text textScore;
    public Button btnLoadScene;


    
    void Start()
    {
        this.gameData = GameObject.FindFirstObjectByType<GameData>();

        this.score = this.gameData.score;
        this.apple = this.gameData.apple;
        this.bomb = this.gameData.bomb;


        Debug.LogFormat("{0}{1}{2}", gameData.score, gameData.apple, gameData.bomb);

        this.btnLoadScene.onClick.AddListener(() =>
        {
            
            SceneManager.LoadScene("AppleCatch");
            
            this.gameData.Reset();

        });


    }

    // Update is called once per frame
    void Update()
    {
            this.textScore.text = string.Format("ÃÑ Á¡¼ö : {0}",this.score);
        this.textApple.text = string.Format("»ç°ú °¹¼ö : {0}", this.apple);
            this.textBomb.text = string.Format("ÆøÅº °¹¼ö : {0}",this.bomb);

        this.btnLoadScene.onClick.AddListener(() =>
        {
            SceneManager.LoadScene("AppleCatch");

        });


    }


}
