using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    private bool isEndGame=false;

    public Rotator circle;
	public Spawner spawner;
    public Animator animator;
    public void EndGame() {
        if (isEndGame) return;

        isEndGame=true;
        circle.enabled=false;
        spawner.enabled=false;
        animator.SetTrigger("End-Game");
        Debug.Log("END GAME");
    }

    public void RestartGame() {
        SceneManager.LoadScene("MenuScreen");
    }
}
