using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeHPBar : MonoBehaviour
{
    public Image img;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        float playerHP = GameObject.Find("Tank").GetComponent<Life>().amount;
        if (playerHP >= 0)
        {
            float ratio = playerHP / 100; // ������ ���� �� ���̿� ���߸� �ȴ�
            img.fillAmount = ratio;
        }
    }
}
