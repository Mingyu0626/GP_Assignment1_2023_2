using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public float speed;
    public float delay;
    public int randomMovement;
    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, delay);
        InvokeRepeating("RandomMove", 0, 2);
    }

    // Update is called once per frame
    void Update()
    {
        if (randomMovement == 0) transform.Translate(0, 0, speed * Time.deltaTime);
        if (randomMovement == 1) transform.Translate(0, 0, -speed * Time.deltaTime);
        if (randomMovement == 2) transform.Translate(speed * Time.deltaTime, 0, 0);
        if (randomMovement == 3) transform.Translate(-speed * Time.deltaTime, 0, 0);

    }

    void RandomMove()
    {
        randomMovement = Random.Range(0, 3);
    }
}
