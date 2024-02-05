using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class EndSceneGenerator : MonoBehaviour
{
    private GameData gameData;
    private float apple;
    private float bomb;
    private float score;
    public Text textApple;
    public Text textBomb;
    public Text textScore;



    
    void Start()
    {
        this.gameData = GameObject.FindFirstObjectByType<GameData>();

        this.score = this.gameData.score;
        this.apple = this.gameData.apple;
        this.bomb = this.gameData.bomb;

    }

    // Update is called once per frame
    void Update()
    {
            this.textScore.text = string.Format("ÃÑ Á¡¼ö : {0}",this.score);
        this.textApple.text = string.Format("»ç°ú °¹¼ö : {0}", this.apple);
            this.textBomb.text = string.Format("ÆøÅº °¹¼ö : {0}",this.bomb);
    }
}
