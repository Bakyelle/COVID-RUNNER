using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BackMenuMain : MonoBehaviour
{
    public void BackToMainMenu()
    {
        SceneManager.LoadScene("Menu");
    }

}
