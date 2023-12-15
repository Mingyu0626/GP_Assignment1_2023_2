using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

public class Life : MonoBehaviour
{
    public float amount;
    public bool isPlayer;
    public Volume volume;
    public UnityEvent onDeath;
    public AudioSource HitSound;

    Vignette vignette;
    void Start()
    {
        if (isPlayer)
            volume.profile.TryGet(out vignette);
    }

    // Update is called once per frame
    void Update()
    {
        if (amount <= 0)
        {
            onDeath.Invoke();
            Destroy(gameObject);
        }
        if (isPlayer) checkLifeIsHalf();
    }

    public void playHitSound()
    {
        HitSound.Play();
    }

    public void checkLifeIsHalf()
    {
        if (amount <= 25)
        {
            vignette.active = true;
        }
        else
        {
            vignette.active = false;
        }
    }
}
