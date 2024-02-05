using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class GameData : MonoBehaviour
{
    public float score=0;
    public float apple=0;
    public float bomb = 0;

    private void Awake()
    {
        DontDestroyOnLoad(this.gameObject);

    }
    

    public void UpdateData(float score, float apple, float bomb)
    {
        this.score = score;
        this.apple = apple;
        this.bomb = bomb;


    }

    public float GetScore()
    {
        return this.score;

    }

    public float GetApple()
    {
        return this.apple;

    }

    public float GetBomb()
    {
        return this.bomb;

    }
}
