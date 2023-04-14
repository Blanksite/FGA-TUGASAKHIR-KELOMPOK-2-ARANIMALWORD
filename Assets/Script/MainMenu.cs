using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {

 

    public void MainMenuu()
    {
        DontDestroyOnLoad(this);
        SceneManager.LoadScene("MainMenu");
    }


    public void Animal()
    {
        DontDestroyOnLoad(this);
        SceneManager.LoadScene("Animal");
    }

    public void Udara()
    {
        DontDestroyOnLoad(this);
        SceneManager.LoadScene("Udara");
    }
    public void Air()
    {
        DontDestroyOnLoad(this);
        SceneManager.LoadScene("Air");
    }
    public void Darat()
    {
        DontDestroyOnLoad(this);
        SceneManager.LoadScene("Darat");
    }


    public void ARCamera()
    {
        DontDestroyOnLoad(this);
        SceneManager.LoadScene("ARCamera");
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
