using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Text;

public class GetScore : MonoBehaviour
{
    private Manager manager;
    public Text scoreText;
    private string[] statements = {"Game Over", "Disappointing","Better Luck Next Time"};

    public bool isOver;
    void Start(){
        manager = FindObjectOfType<Manager>();
        
    }
    void Update(){
        string sc = manager.getScore().ToString();
        //Debug.Log(sc);
        //scoreText.text = "OBSTACLES DODGED: "+sc;
        scoreText.text = "OBSTACLES DODGED: "+sc;
        if(manager.isOver() && isOver==false){
            scoreText.text = statements[(int)(Random.Range(0,3))];
            isOver = true;

        }
    }
}
