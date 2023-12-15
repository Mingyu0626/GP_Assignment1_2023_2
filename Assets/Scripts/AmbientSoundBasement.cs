using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmbientSoundBasement : MonoBehaviour
{
    public float audioRange; // 오디오 재생 범위

    private AudioSource audioSource;
    private Transform player; // 주변에 있는 플레이어 또는 다른 대상
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        player = GameObject.FindGameObjectWithTag("Player").transform; // 플레이어를 찾아서 할당하거나 다른 대상을 할당합니다.
    }

    void Update()
    {
        // 주변에 있는 플레이어와의 거리를 측정합니다.
        float distanceToPlayer = Vector3.Distance(transform.position, player.position);
        // 만약 거리가 오디오 재생 범위 이내라면 오디오를 재생합니다.
        if (distanceToPlayer <= audioRange)
        {
            if (!audioSource.isPlaying)
            {
                audioSource.Play();
            }
        }
        else
        {
            // 거리가 범위를 벗어나면 오디오를 정지합니다.
            audioSource.Stop();
        }
    }
}

