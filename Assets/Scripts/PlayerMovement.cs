using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine;

public class PlayerBehavior : MonoBehaviour
{
    public bool isDash = false;
    public float speed;
    public float rotationSpeed;

    private Rigidbody rb;
    private Vector2 movementValue;
    private float lookValue;

    private void Awake()
    {
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;

        rb = GetComponent<Rigidbody>();
    }

    public void OnMove(InputValue value)
    {
        movementValue = value.Get<Vector2>() * speed;
    }

    public void OnLook(InputValue value)
    {
        lookValue = value.Get<Vector2>().x * rotationSpeed;
    }

    public void OnDash(InputValue value)
    {
        if (!isDash)
        {
            speed = speed * 2;
            isDash = true;
        }
        else 
        {
            speed = speed / 2;
            isDash = false;
        }
    }

    void Update()
    {
        rb.AddRelativeForce(
            movementValue.x * Time.deltaTime, 
            0,
            movementValue.y * Time.deltaTime);

        rb.AddRelativeTorque(0, lookValue * Time.deltaTime, 0);


        //// 플레이어(탱크)의 반시계 방향 회전
        //if (Input.GetKey(KeyCode.Q))
        //{
        //    transform.Rotate(0, -10 * rotationSpeed * Time.deltaTime, 0);
        //}

        //// 플레이어(탱크)의 시계 방향 회전
        //if (Input.GetKey(KeyCode.E))
        //{
        //    transform.Rotate(0, 10 * rotationSpeed * Time.deltaTime, 0);
        //}
    }
}
