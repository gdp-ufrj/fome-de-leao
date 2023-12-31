using UnityEngine;

public class MenuControllerScript : MonoBehaviour
{
    public GameObject MainMenu, CreditsDisplay, ControlsDisplay;

    //funcao usada no botao de comecar
    public void StartButtonFunction()
    {
        SoundController.GetInstance().PlaySound("btn_click", null);
        TransitionsController.GetInstance().LoadNextScene();
    }

    //funcao usada no botao de mostrar controles
    public void ControlsButtonFunction()
    {
        SoundController.GetInstance().PlaySound("btn_click", null);
        MainMenu.SetActive(false);
        ControlsDisplay.SetActive(true);
    }

    //funcao usada no botao de mostrar creditos
    public void CreditsButtonFunction()
    {
        SoundController.GetInstance().PlaySound("btn_click", null);
        MainMenu.SetActive(false);
        CreditsDisplay.SetActive(true);
    }

    //funcao usada no botao de sair do jogo
    public void ExitButtonFunction()
    {
        Application.Quit();
    }

    //funcao usada no botao de retornar pro menu principal
    public void ReturnButtonFunction()
    {
        SoundController.GetInstance().PlaySound("btn_click", null);
        MainMenu.SetActive(true);
        CreditsDisplay.SetActive(false);
        ControlsDisplay.SetActive(false);
    }
}
