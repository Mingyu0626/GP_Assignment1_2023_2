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

    void Update()
    {
        float playerHP = GameObject.Find("Tank").GetComponent<Life>().amount;
        if (playerHP >= 0)
        {
            float ratio = playerHP / 50; // ������ ���� �÷��̾�(��ũ) ü�¿� ���߸� �ȴ�
            img.fillAmount = ratio;
        }
    }
}
