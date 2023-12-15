using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;

public class TimeControl : MonoBehaviour
{
    public TextMeshProUGUI textMin;
    public TextMeshProUGUI textSec;
    float time = 60; // 제한 시간 60초
    int min, sec;

    void Start()
    {
    }

    void Update()
    {
        time -= Time.deltaTime;

        min = (int)time / 60;
        sec = ((int)time - min * 60) % 60;

        if (min == 0 && sec == 0)
        {
            SceneManager.LoadScene("WinScreen");
        }

        if (min <= 0 && sec <= 0)
        {
            textMin.text = "00";
            textSec.text = "00";
        }

        else
        {
            if (sec >= 60)
            {
                min += 1;
                sec -= 60;
            }
            else
            {
                textMin.text = "0" + min.ToString();
                if (0 < sec && sec < 10) textSec.text = "0" + sec.ToString();
                else textSec.text = sec.ToString();
            }
        }
    }
}
