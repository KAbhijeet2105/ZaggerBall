using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UiManager : MonoBehaviour {


    public static UiManager instance;

    public GameObject GameZaggerPanel;
    public GameObject GameOverPanel;
    public GameObject TapText;
    public Text Score;
    public Text HighScore1;
    public Text HighScore2;
    public Text RuntimeScore;

    void Awake() {
        if (instance==null) {
            instance = this;
        }
    
    }

    public void GameStart() {
       
        TapText.SetActive(false);
        GameZaggerPanel.GetComponent<Animator>().Play("PanelUp");

    }

    public void GameOver() {

        Score.text = PlayerPrefs.GetInt("score").ToString();
        HighScore2.text = PlayerPrefs.GetInt("highscore").ToString();
        GameOverPanel.SetActive(true);
    
     }

    public void reset() {
        SceneManager.LoadScene(0);
    
    }








    // Use this for initialization
    void Start () {
        HighScore1.text = "High Score: "+PlayerPrefs.GetInt("highscore").ToString();
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
