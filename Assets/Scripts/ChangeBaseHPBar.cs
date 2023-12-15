using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeBaseHPBar : MonoBehaviour
{
    public Image img;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        float baseHP = GameObject.Find("Basement").GetComponent<Life>().amount;
        if (baseHP >= 0)
        {
            float ratio = baseHP / 20; // ������ ���� ���� ü�¿� ���߸� �ȴ�
            img.fillAmount = ratio;
        }
    }
}
