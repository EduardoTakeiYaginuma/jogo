using UnityEngine;

public class StopMusicOnGameOver : MonoBehaviour
{
    // Referência para o componente AudioSource do GameObject que toca a música
    private AudioSource musicSource;
    // Flag para garantir que pare a música apenas uma vez
    private bool hasStopped = false;

    void Start()
    {
        // Obtém o AudioSource presente no GameObject
        musicSource = GetComponent<AudioSource>();
    }

    void Update()
    {
        // Verifica se o game está em GameOver e se a música ainda não foi parada
        if (GameController.gameOver && !hasStopped)
        {
            // Para a música
            musicSource.Stop();
            hasStopped = true;
        }
    }
}
