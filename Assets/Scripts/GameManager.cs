using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

   public static GameManager instance;
    public bool gameover; 
    void Awake() {
        if(instance == null)
        {
            instance = this;
            }   
    }

	// Use this for initialization
	void Start () {

        gameover = false;

	}
	
	// Update is called once per frame
	void Update () {
		
	}


    public void Gamestart()
    {
        UiManager.instance.GameStart();
        ScoreManager.instance.startScore();

        GameObject.Find("PlatformSpawner").GetComponent<PlatformSpawner>().startSpwaningPlatform();
    
    }

   public void Gameover() {
        UiManager.instance.GameOver();
        ScoreManager.instance.stopScore();
        gameover = true;


    }



}
