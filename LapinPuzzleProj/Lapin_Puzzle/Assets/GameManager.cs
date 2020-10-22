using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    private static GameManager instance = null;
    public static GameManager sharedInstance
    {

        //Accesseur automatique
        get
        {
            if (instance == null)
            {
                instance = GameObject.FindObjectOfType<GameManager>();
            }
            return instance;
        }
    }

    public bool isPaused = false;

    public bool levelWon = false;

    public bool levelFailed = false;

    public int grassNb = 0;

    void Start()
    {
        grassNb = 0;
    }

    void Update()
    {
        if (grassNb <= 0 && !levelFailed && !levelWon)
        {
            Debug.Log("WON");
            UIManager.sharedInstance.VictoryAnim();
            SoundManager.sharedInstance.Victory();
            levelWon = true;
        }

        if (Input.GetKeyDown(KeyCode.R) && !isPaused && !levelWon)
        {
            RestartLevel();
        }

        if (levelFailed)
        {
            Debug.Log("FAILED");
        }
    }

    private void RestartLevel()
    {
        Scene scene = SceneManager.GetActiveScene();
        
        SceneManager.LoadScene(scene.name);
    }
}
