using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TitleButtons : MonoBehaviour
{
    public void ClickStart()
    {
        GameManager.Instance.Play();
    }
    public void ClickNewGame()
    {
        Wizard.stats = new Playerstats();
        GameManager.Instance.Play();
    }
    public void ClickExit()
    {
        Application.Quit();
    }
}
