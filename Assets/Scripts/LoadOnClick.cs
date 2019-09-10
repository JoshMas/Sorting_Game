using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class LoadOnClick : MonoBehaviour {

    public void GotoMainScene()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void GotoGameScene()
    {
        SceneManager.LoadScene("GameScene");
    }

    public void GotoCategoryScene()
    {
        SceneManager.LoadScene("CategoryScene");
    }

}