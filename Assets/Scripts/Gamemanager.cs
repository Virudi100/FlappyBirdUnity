using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Gamemanager : MonoBehaviour
{
    public GameObject gameoverCanvas;

    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1;
    }

   public void GameOver ()
    {
        //Active le canvas de gameover et freeze le jeu
        gameoverCanvas.SetActive(true);
        Time.timeScale = 0;
    }

    public void replay()
    {
        //recharge la scene
        SceneManager.LoadScene(0);
    }
}
