using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class exit : MonoBehaviour
{
    public void exitClass()
    {
        Application.Quit();
    }
    public void goBack()
    {
        SceneManager.LoadScene(1);
    }
}
