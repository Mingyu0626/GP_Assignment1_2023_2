using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    void Start()
    {
        EnemiesManager.instance.enemies.Add(this);
    }

    void OnDestroy()
    {
        EnemiesManager.instance.enemies.Remove(this);
    }
}
