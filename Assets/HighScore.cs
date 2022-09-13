using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class HighScore : MonoBehaviour
{
    static public int score = 1000;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        TMP_Text gt = this.GetComponent<TMP_Text>();  
        gt.text = "High Score: " + score; 

        //Update HighScore in PlayerPrefs if necessary
        if(score > PlayerPrefs.GetInt("HighScore")){
            PlayerPrefs.SetInt("HighScore", score);
        }
    }

    void Awake() {
        // if HighScore value already exists in PlayerPrefs, read it
        if (PlayerPrefs.HasKey("HighScore")){
            score = PlayerPrefs.GetInt("HighScore");
        }

        //Save the High Score to a local storage
        PlayerPrefs.SetInt("HighScore", score);
    }
}
