using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour {

    public static ScoreManager instance;
    public int score;
    public int highscore;


    void Awake() {
        if (instance == null)
        {

            instance = this;
        }
     }

	// Use this for initialization
	void Start () {

        score = 0;
        PlayerPrefs.SetInt("score",score);
	}
	
	// Update is called once per frame
	void Update () {
		

	}

   public void incrementScore() {

      
        score += 1;
        UiManager.instance.RuntimeScore.text = " " + score.ToString();
    }
   public void startScore() {

        InvokeRepeating("incrementScore",0.1f,0.5f);
    
    }


  public  void stopScore()
    {


        CancelInvoke("incrementScore");

        PlayerPrefs.SetInt("score", score);

        if (PlayerPrefs.HasKey("highscore"))
        {

            if (score > PlayerPrefs.GetInt("highscore"))
            {

                PlayerPrefs.SetInt("highscore",score);
            
            }


         }
        else 
        {
            PlayerPrefs.SetInt("highscore",score);
        
         }


    }


}
