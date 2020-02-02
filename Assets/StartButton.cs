using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartButton : MonoBehaviour
{
    public void OnClick()
    {
        Debug.Log("Click");
        SceneManager.LoadScene(1);
    }
    
    public void GoToStart()
    {
        SceneManager.LoadScene(0);
    }
}
