using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    public GameObject MainMenu;
    public GameObject OptionsMenu;
    public GameObject PauseMenu;
    public GameObject HUD;
    public GameObject GameWin;
    public GameObject GameOver;
    public GameManager gameManager;
    void ResetObjects()
    {
        MainMenu.SetActive(false);
        OptionsMenu.SetActive(false);
        PauseMenu.SetActive(false);
        HUD.SetActive(false);
        GameOver.SetActive(false);
        GameWin.SetActive(false);
    }
    public void SetMainMenu()
    {
        ResetObjects();
        MainMenu.SetActive(true);
    }
    public void SetOptionsMenu()
    {
        ResetObjects();
        OptionsMenu.SetActive(true);
    }
    public void SetPauseMenu()
    {
        ResetObjects();
        PauseMenu.SetActive(true);
    }
    public void SetHUDActive()
    {
        ResetObjects();
        HUD.SetActive(true);
    }
    public void SetGameOver()
    {
        ResetObjects();
        GameOver.SetActive(true);
    }
    public void SetGameWin()
    {
        ResetObjects();
        GameWin.SetActive(true);
    }
}
