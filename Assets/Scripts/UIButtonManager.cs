using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class UIButtonManager : MonoBehaviour
{
    // Start is called before the first frame update
    private bool isPause = false;

    [SerializeField] private GameObject pauseMenuUI;
    void Start()
    {
        pauseMenuUI.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (!isPause) Pause();
            else Resume();
        }
    }
    public void Pause()
    {
        Time.timeScale = 0;
        pauseMenuUI.SetActive(true);
        isPause = true;
    }

    public void Resume()
    {
        Time.timeScale = 1f;
        pauseMenuUI.SetActive(false);
        isPause = false;
    }

}
