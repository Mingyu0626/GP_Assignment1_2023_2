using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WavesGameMode : MonoBehaviour
{
    [SerializeField] Life playerLife;
    [SerializeField] Life basementLife;
    void Start()
    {
        Invoke("CheckWavesEnd", 90);
    }
    void Update()
    {
        if (EnemiesManager.instance.enemies.Count <= 0 && WavesManager.instance.waves.Count <= 0)
        {
            SceneManager.LoadScene("WinScreen");
        }

        if (playerLife.amount <= 0 || EnemiesManager.instance.enemies.Count >= 100000)
        {
            SceneManager.LoadScene("LoseScreen");
        }

        //if (basementLife.amount <= 10)
        //{
        //    SceneManager.LoadScene("LoseScreen");
        //}
    }

    void CheckWavesEnd()
    {
        if (WavesManager.instance.waves.Count <= 0)
        {
            SceneManager.LoadScene("WinScreen");
        }
    }
}
