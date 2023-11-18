using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine;

public class EnemeShooting : MonoBehaviour
{
    public GameObject prefab;
    public GameObject shootPoint;
    public float shootRate;
    private void Start()
    {
        InvokeRepeating("Shoot", 0, shootRate);
    }

    void Shoot()
    {
        Instantiate(prefab, transform.position, transform.rotation);
    }
}
