using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManagement : MonoBehaviour
{
    [SerializeField] public bool winLevel1 = false;
    public void PlayBtn()
    {
        SceneManager.LoadSceneAsync("Level 1");
    }

    public void QuitBtn()
    {
        Application.Quit();
    }

    public void WinBtnLevel1()
    {
        winLevel1 = true;
        SceneManager.LoadSceneAsync("Level Menu 2");
    }
    public void WinBtnLevel2()
    {
        winLevel1 = true;
        SceneManager.LoadSceneAsync("Level Menu 3");
    }
   
    public void GameOverBtnLevel1()
    {
        SceneManager.LoadSceneAsync("Level 1");
    }

    public void GameOverBtnLevel2()
    {
        SceneManager.LoadSceneAsync("Level 2");
    }

    public void GameOverBtnLevel3()
    {
        SceneManager.LoadSceneAsync("Level 3");
    }

    public void Level1Btn()
    {
        SceneManager.LoadSceneAsync("Level 1");
    }
    public void Level2Btn()
    {
        SceneManager.LoadSceneAsync("Level 2");
    }

    public void Level3Btn()
    {
        SceneManager.LoadSceneAsync("Level 3");
    }

    public void MainMenuBtn()
    {
        SceneManager.LoadSceneAsync("Menu");
    }

}
