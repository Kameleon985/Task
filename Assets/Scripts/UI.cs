using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UI : MonoBehaviour
{
    public GameObject PlayButton;
    public GameObject SettingsButton;
    public GameObject ExitButton;
    public GameObject Buttons;
    public GameObject CheckBoxes;
    private int ChoosenButton = 0;
    private int ButtonCount = 3;



    private void Update()
    {

        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            if (ChoosenButton > ButtonCount)
            {
                ChoosenButton = (ChoosenButton - 1);
            }
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            if (ChoosenButton < ButtonCount - 1)
            {
                ChoosenButton = (ChoosenButton + 1);
            }

        }
        else if (Input.GetKeyDown(KeyCode.Return))
        {
            Choose(ChoosenButton);
        }
        else if (Input.GetKeyDown(KeyCode.Escape))
        {
            Exit();
        }
    }

    public void Choose(int option)
    {
        switch (option)
        {
            case 0:
                Play();
                break;
            case 1:
                SwitchSettings();
                break;
            case 2:
                Exit();
                break;
            default:
                break;
        }
    }

    public void SwitchSettings()
    {
        Buttons.SetActive(!Buttons.activeSelf);
        CheckBoxes.SetActive(!CheckBoxes.activeSelf);
    }

    public void Play()
    {
        SceneManager.LoadScene("Game");
    }
    public void Exit()
    {
        if (CheckBoxes.activeSelf)
        {
            SwitchSettings();
        }
        else
        {
            Application.Quit();
        }

    }
}
