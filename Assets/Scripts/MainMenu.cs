using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class MainMenu : MonoBehaviour
{
    public GameObject CreditsObject;
    public GameObject MainMenuObject;

    public void StartGame()
    {
        //GameObject.Find("SoundManager").GetComponent<SoundManager>().playAudio("button");
        SceneManager.LoadScene("Main");
    }

    public void ShowCredits()
    {
       // GameObject.Find("SoundManager").GetComponent<SoundManager>().playAudio("button");
        MainMenuObject.SetActive(false);
        CreditsObject.SetActive(true);

    }

    public void HideCredits()
    {
        //GameObject.Find("SoundManager").GetComponent<SoundManager>().playAudio("button");
        MainMenuObject.SetActive(true);
        CreditsObject.SetActive(false);

    }

    public void QuitBtn()
    {
        //GameObject.Find("SoundManager").GetComponent<SoundManager>().playAudio("button");
        Application.Quit();
    }

    public void GoToMenu()
    {
       // GameObject.Find("SoundManager").GetComponent<SoundManager>().playAudio("button");
        SceneManager.LoadScene("Menu");

    }
}
