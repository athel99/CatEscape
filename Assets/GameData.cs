using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class GameData : MonoBehaviour
{
    public float score;
    public float apple;
    public float bomb;

    private void Awake()
    {
        DontDestroyOnLoad(this.gameObject);

    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
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
