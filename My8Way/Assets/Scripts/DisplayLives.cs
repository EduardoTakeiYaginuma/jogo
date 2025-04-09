using UnityEngine;
using UnityEngine.UI;

public class DisplayLives : MonoBehaviour
{
    // Referência ao componente Text que exibirá as vidas.
    public Text vidasText;

    private void Start()
    {
        // Inicializa as vidas (garanta que o GameController.Init() seja chamado no início do jogo).
        GameController.Init();
        AtualizaTexto();
    }

    private void Update()
    {
        // Aqui você pode atualizar o texto a cada frame,
        // mas é mais eficiente atualizar somente quando a quantidade de vidas mudar.
        AtualizaTexto();
    }

    // Método para atualizar o texto da UI com a quantidade de vidas restantes.
    void AtualizaTexto()
    {
        vidasText.text = "Vidas Restantes: " + GameController.VidasRestantes.ToString();
    }
}
