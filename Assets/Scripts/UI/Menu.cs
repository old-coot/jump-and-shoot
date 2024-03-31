using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public GameObject MenuButton;
    public GameObject MenuWindow;
    public MonoBehaviour[] ComponenetsToDisable;

    public void OpenMenuWindow(){
        MenuButton.SetActive(false);
        MenuWindow.SetActive(true);
        for (int i = 0; i < ComponenetsToDisable.Length; i++)
        {
            ComponenetsToDisable[i].enabled = false;
        }
        Time.timeScale = 0.00001f;
    }

    public void CloseMenuWindow(){
        MenuButton.SetActive(true);
        MenuWindow.SetActive(false);
        for (int i = 0; i < ComponenetsToDisable.Length; i++)
        {
            ComponenetsToDisable[i].enabled = true;
        }
        Time.timeScale = 1f;
    }

    public void Restart(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

}
