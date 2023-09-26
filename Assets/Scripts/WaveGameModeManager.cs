using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WaveGameModeManager : MonoBehaviour
{
    [SerializeField] private Life playerLife;
    [SerializeField] private Life playerBaseLife;

    void Start()
    {
        playerLife.onDeath.AddListener(OnPlayerOrBaseDied);
        playerBaseLife.onDeath.AddListener(OnPlayerOrBaseDied);
        EnemiesManager.instance.onChanged.AddListener(CheckWinCondition);
        WavesManager.instance.onChanged.AddListener(CheckWinCondition);
        EnemiesManager.instance.onChanged.AddListener(CheckLoseCondition);
    }

    void OnPlayerOrBaseDied()
    {
        SceneManager.LoadScene("LoseScreen");
    }

    void CheckWinCondition()
    {
        if (WavesManager.instance.waves.Count <= 0 
            || EnemiesManager.instance.enemies.Count <= 0)
        {
            SceneManager.LoadScene("WinScreen");
        }
    }

    void CheckLoseCondition()
    {
        if (EnemiesManager.instance.enemies.Count >= 30)
        {
            SceneManager.LoadScene("LoseScreen");
        }
    }
}
