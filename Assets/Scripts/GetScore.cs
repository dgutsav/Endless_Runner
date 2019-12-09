using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GetScore : MonoBehaviour
{
    private Manager manager;
    public Text scoreText;
    void Start(){
        manager = FindObjectOfType<Manager>();
    }
    void Update(){
        string sc = manager.getScore().ToString();
        //Debug.Log(sc);
        //scoreText.text = "OBSTACLES DODGED: "+sc;
        scoreText.text = "OBSTACLES DODGED: "+sc;
    }
}
