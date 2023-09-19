using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehavior : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }
    public bool isDash = false;
    public float speed;
    public float rotationSpeed;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(0, 0, speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(0, 0, -speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(-speed * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(speed * Time.deltaTime, 0, 0);
        }

        if (Input.GetKey(KeyCode.Z))
        {
            if (!isDash)
            {
                speed = speed * (float)2;
                isDash = true;
            }

        }

        if (Input.GetKey(KeyCode.C))
        {
            if (isDash)
            {
                speed = speed / (float)2;
                isDash = false;
            }

        }


        // 반시계 회전 회오리
        if (Input.GetKey(KeyCode.Q))
        {
            transform.Rotate(0, -10 * rotationSpeed * Time.deltaTime, 0);
        }

        // 시계 회전 회오리
        if (Input.GetKey(KeyCode.E))
        {
            transform.Rotate(0, 10 * rotationSpeed * Time.deltaTime, 0);
        }
    }

}
