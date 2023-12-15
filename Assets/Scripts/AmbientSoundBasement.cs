using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmbientSoundBasement : MonoBehaviour
{
    public float audioRange; // ����� ��� ����

    private AudioSource audioSource;
    private Transform player; // �ֺ��� �ִ� �÷��̾� �Ǵ� �ٸ� ���
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        player = GameObject.FindGameObjectWithTag("Player").transform; // �÷��̾ ã�Ƽ� �Ҵ��ϰų� �ٸ� ����� �Ҵ��մϴ�.
    }

    void Update()
    {
        // �ֺ��� �ִ� �÷��̾���� �Ÿ��� �����մϴ�.
        float distanceToPlayer = Vector3.Distance(transform.position, player.position);
        // ���� �Ÿ��� ����� ��� ���� �̳���� ������� ����մϴ�.
        if (distanceToPlayer <= audioRange)
        {
            if (!audioSource.isPlaying)
            {
                audioSource.Play();
            }
        }
        else
        {
            // �Ÿ��� ������ ����� ������� �����մϴ�.
            audioSource.Stop();
        }
    }
}

