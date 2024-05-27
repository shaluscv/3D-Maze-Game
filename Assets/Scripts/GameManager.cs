using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public float timeleft = 20;
    bool gamestatus = false;
    bool gameOver = false;
    public GameObject winText;
    public GameObject gameOverText;
    public GameObject player;
    public PlayerControl playercontrol;
    public TextMeshProUGUI Timertext;
  

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(timeleft >= 0 && !gamestatus) { 
            timeleft -= Time.deltaTime;
            Timertext.text = timeleft.ToString("F2");

        }
        if (timeleft <=0 && !gamestatus)
        {
            GameOver();
        }

        
    }

    public void GameWin()
    {
        gamestatus = true;
        winText.SetActive(true);
        playercontrol.enabled = false;
        player.SetActive(false);
    }

    public void GameOver() {
    
        gameOverText.SetActive(true);
        playercontrol.enabled = false;
        player.SetActive(false);
        gameOver = true;
    }

    public void Restart()
    {
        SceneManager.LoadScene(0);
    }
}
