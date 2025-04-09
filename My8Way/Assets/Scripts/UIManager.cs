using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{

    public GameObject endGamePanel;

    public AudioSource backgroundMusic;

    public GameObject TimerController; 

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Time.timeScale = 1;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (GameController.gameOver)
        {
            Time.timeScale = 0;
            SceneManager.LoadScene(3);
            
            
            // Se a música estiver tocando, para ela
            if (backgroundMusic != null && backgroundMusic.isPlaying)
            {
                backgroundMusic.Stop();
            }
             if (TimerController != null)
            {
                TimerController.SetActive(false);
            }
        }
    }
}
