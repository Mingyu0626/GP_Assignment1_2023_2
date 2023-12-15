using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class WavesGameMode : MonoBehaviour
{
    [SerializeField] Life playerLife;
    [SerializeField] Life basementLife;
    public TextMeshProUGUI currnetEnemies;
    void Start()
    {
    }
    void Update()
    {
        if (EnemiesManager.instance.enemies.Count <= 0 && WavesManager.instance.waves.Count <= 0)
        {
            SceneManager.LoadScene("WinScreen");
        }

        if (playerLife.amount <= 0 || EnemiesManager.instance.enemies.Count >= 40 || basementLife.amount <= 0)
        {
            SceneManager.LoadScene("LoseScreen");
        }
        currnetEnemies.text = EnemiesManager.instance.enemies.Count.ToString();
    }

    void CheckWavesEnd()
    {
        if (WavesManager.instance.waves.Count <= 0)
        {
            SceneManager.LoadScene("WinScreen");
        }
    }
}
