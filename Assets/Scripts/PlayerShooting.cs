using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShooting : MonoBehaviour
{
    public GameObject prefab;
    public GameObject shootPoint;
    public bool isShotgunMode = false;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            if (!isShotgunMode) isShotgunMode = true;
            else isShotgunMode = false;
        }

        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            Instantiate(prefab, transform.position, transform.rotation);
            if (isShotgunMode)
            {
                GameObject clone1 = Instantiate(prefab);
                clone1.transform.position = transform.position;
                clone1.transform.rotation = transform.rotation;
                clone1.transform.Translate(2, 0, 0);

                GameObject clone2 = Instantiate(prefab);
                clone2.transform.position = transform.position;
                clone2.transform.rotation = transform.rotation;
                clone2.transform.Translate(-2, 0, 0);

            }

        }
    }
}
