using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ContactDamager : MonoBehaviour
{
    public float damage;
    private AudioSource playerHitSound;

    void Start()
    {
        playerHitSound = GetComponent<AudioSource>();
    }
    void OnTriggerEnter(Collider other)
    {
        Life life = other.GetComponent<Life>();

        if (life != null)
        {
            life.amount -= damage;
            if (other.CompareTag("Player"))
            {
                life.playHitSound();
            }
            Destroy(gameObject);
        }
    }
}
