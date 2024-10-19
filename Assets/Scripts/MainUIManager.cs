using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainUIManager : MonoBehaviour
{

    public void discoverButton() {
        SceneManager.LoadScene(1);
    }

    public void startButton() {
        SceneManager.LoadScene(2);
    }

    public void backMenu() {
        SceneManager.LoadScene(0);
    }
}
