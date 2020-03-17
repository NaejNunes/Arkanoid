using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartMenuBehaviour : MonoBehaviour
{
    public GameObject creditisPanel;

    public void PressPlay()
    {
        SceneManager.LoadScene("MainGame", LoadSceneMode.Single);
    }

    public void PressCreditis(bool show)
    {
        creditisPanel.SetActive(show);
    }
    // Update is called once per frame    
}
