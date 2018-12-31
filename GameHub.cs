using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameHub : MonoBehaviour
{
    bool isOver = false;
    float delayRestart = 2f;
    public GameObject Panel;
    public Text t;
    // Start is called before the first frame update
    public void EndGame() //losing the game
    {
        if (!isOver)
        {
            t.text = "GAME OVER";
            //we use invoke function to make a delay!
            Invoke("RestartGame", delayRestart);
        }
    }
    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void CompleteLevel()
    {
        Debug.Log("LEVEL 1 COMPLETE");
        Panel.SetActive(true);
    }
}
