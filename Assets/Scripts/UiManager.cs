using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UiManager : MonoBehaviour
{
    public static UiManager instance;

    public GameObject zigzagPanel;
    public GameObject gameOverPanel;
    public GameObject tapText;
    public GameObject displayScoreBottom;
    public Text displayScore;
    public Text score;
    public Text highScore1;
    public Text highScore2;

    void Awake(){
    	if(instance == null){
    		instance = this;
    	}
    }

    // Start is called before the first frame update
    void Start()
    {
        highScore1.text = "High Score: " + PlayerPrefs.GetInt("highScore");
        tapText.SetActive(true);
        zigzagPanel.SetActive(true);
        
    }

    public void GameStart(){
    	tapText.GetComponent<Animator>().Play("textDown");
    	zigzagPanel.GetComponent<Animator>().Play("panelUp");
    	displayScoreBottom.SetActive(true);	   	
    }

    public void GameOver(){
    	score.text = PlayerPrefs.GetInt("score").ToString();
    	highScore2.text = PlayerPrefs.GetInt("highScore").ToString();
    	gameOverPanel.SetActive(true);
    	gameOverPanel.GetComponent<Animator>().Play("gameOverPanelAppear");
    	displayScoreBottom.GetComponent<Animator>().Play("scoreDown");	    
    }

    public void Reset(){
    	SceneManager.LoadScene(0);
    }
    // Update is called once per frame
    void Update()
    {
     	 displayScore.text = PlayerPrefs.GetInt("score").ToString();  
    }
}
