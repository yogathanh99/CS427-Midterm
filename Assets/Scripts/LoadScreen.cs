using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScreen : MonoBehaviour
{
    public void LoadHardGame(){
        SceneManager.LoadScene("HardGame");
    }
    public void LoadEasyGame(){
        SceneManager.LoadScene("EasyGame");
    }

    public void LoadLevelScreen(){
        SceneManager.LoadScene("LevelScreen");
    }
}
