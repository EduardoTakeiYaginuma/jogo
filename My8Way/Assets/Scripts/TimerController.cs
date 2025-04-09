using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TimerController : MonoBehaviour
{
    public float totalTime = 30f;
    public Text timerText;
    private float currentTime;

    void Start()
    {
        currentTime = totalTime;
        UpdateTimerDisplay();
    }

    void Update()
    {
        if (currentTime > 0)
        {
            currentTime -= Time.deltaTime;
            if (currentTime < 0)
                currentTime = 0;
            UpdateTimerDisplay();
            Debug.Log("Tempo Atual: " + currentTime);
        }
        else
        {
            TimerFinished();
        }
    }

    void UpdateTimerDisplay()
    {
        int seconds = Mathf.FloorToInt(currentTime);
        timerText.text = "Tempo: " + seconds.ToString();
    }

    void TimerFinished()
    {
        Debug.Log("Tempo Acabou!");
        SceneManager.LoadScene("Win");
    }
}
