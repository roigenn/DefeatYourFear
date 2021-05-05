using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class cynophobiapanel : MonoBehaviour
{
    public GameObject mainmenu;
    public GameObject panel;
    public GameObject player;
    public GameObject camera1;

    public void Start()
    {
        player.SetActive(false);
        camera1.SetActive(true);
    }
    public void MainMenu()
    {
        mainmenu.SetActive(true);
        panel.SetActive(false);
    }
    public void gamestart()
    {
        mainmenu.SetActive(false);
        player.SetActive(true);
        camera1.SetActive(false);
    }
    
    public void Panel()
    {
        mainmenu.SetActive(false);
        panel.SetActive(true);
        

    }
    public void BackButton()
    {
        SceneManager.LoadScene(1);
    }
    public void Panelback()
    {
        mainmenu.SetActive(true);
        panel.SetActive(false);
       
    }

}
