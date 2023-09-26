using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;



public class EnemiesManager : MonoBehaviour
{
    public static EnemiesManager instance;
    public List<Enemy> enemies;
    public UnityEvent onChanged;

    public void AddEnemy(Enemy enemy)
    {
        enemies.Add(enemy);
        onChanged.Invoke();
    }

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            print("Duplicated EnimiesManger, igonoring this one");
            Debug.Log("Duplicated EnimiesManager, igonoring this one", gameObject);
            Debug.LogError("Duplicated");
        }
    }
}
