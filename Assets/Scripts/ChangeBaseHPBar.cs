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
            float ratio = baseHP / 20; // 나누는 수는 기지 체력에 맞추면 된다
            img.fillAmount = ratio;
        }
    }
}
