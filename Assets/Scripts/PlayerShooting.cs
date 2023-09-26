using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine;

public class PlayerShooting : MonoBehaviour
{
    public GameObject prefab;
    public GameObject shootPoint;
    public bool isShotgunMode = false;

    public void OnFire(InputValue value)
    {
        if (value.isPressed)
        {
            if (!isShotgunMode)
            {
                GameObject clone = Instantiate(prefab);

                clone.transform.position = shootPoint.transform.position;
                clone.transform.rotation = shootPoint.transform.rotation;
            }
            else
            {
                Instantiate(prefab, shootPoint.transform.position, shootPoint.transform.rotation);

                GameObject clone1 = Instantiate(prefab);
                clone1.transform.position = shootPoint.transform.position;
                clone1.transform.rotation = shootPoint.transform.rotation;
                clone1.transform.Translate(3, 0, 0);

                GameObject clone2 = Instantiate(prefab);
                clone2.transform.position = shootPoint.transform.position;
                clone2.transform.rotation = shootPoint.transform.rotation;
                clone2.transform.Translate(-3, 0, 0);


            }
        }
    }

    public void OnChangeMode(InputValue value)
    {
        if (value.isPressed)
        {
            if (!isShotgunMode) isShotgunMode = true;
            else isShotgunMode = false;
        }
    }
}
