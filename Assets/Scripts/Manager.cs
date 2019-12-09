using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour
{
    private bool over;
    private int score = 0;
    void Start(){
        over = false;
    }
    public void GameOver(){
        Debug.Log("game over");
        over = true;
    }
    public bool isOver(){
        return over;
    }
    public void incrementScore(){
        if(!over)
            score++;
    }
    public int getScore(){
        Debug.Log(score.ToString());
        return score;
    }
}
