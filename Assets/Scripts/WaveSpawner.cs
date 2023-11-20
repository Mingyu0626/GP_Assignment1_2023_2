using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaveSpawner : MonoBehaviour
{
    public GameObject prefab;
    public float startTime;
    public float endTime;
    private float spawnRate = 2;
    public float rotationSpeed;

    public float moveDistance = 0.5f;
    private float count = -1;

    private void Start()
    {
        WavesManager.instance.waves.Add(this);
        InvokeRepeating("Spawn", startTime, spawnRate);
        InvokeRepeating("SquareMove", startTime, spawnRate);
        Invoke("EndSpawner", endTime);
    }

    void Spawn()
    {
        Instantiate(prefab, transform.position, transform.rotation);
    }

    void EndSpawner()
    {
        WavesManager.instance.waves.Remove(this);
        CancelInvoke();
    }

    void Update()
    {
    }

    void SquareMove()
    {
        print("SquareMove");
        count += 1;
        switch (count % 4)
        {
            case 0:
                moveForward();
                break;
            case 1:
                moveLeft();
                break;
            case 2:
                moveRight();
                break;
            case 3:
                moveBack();
                break;
        }
    }


    void moveForward()
    {
        transform.Translate(Vector3.forward * moveDistance * 1f);
    }

    void moveLeft()
    {
        transform.Translate(Vector3.left * moveDistance * 1f);
    }

    void moveRight()
    {
        transform.Translate(Vector3.right * moveDistance * 1f);
    }

    void moveBack()
    {
        transform.Translate(Vector3.back * moveDistance * 1f);
    }
}
