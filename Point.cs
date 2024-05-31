using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Point : MonoBehaviour
{
    public FloppybirdripoffGameManager FloppybirdripoffGameManager;
    public AudioSource audioSource;

    public void Start()
    {
        FloppybirdripoffGameManager = GameObject.FindObjectOfType<FloppybirdripoffGameManager>();
        audioSource = GetComponent<AudioSource>();
    }

    void OnTriggerEnter2D(Collider2D target)
    {
        if (target.gameObject.CompareTag("Player"))
        {
            FloppybirdripoffGameManager.PointAdd();
            audioSource.Play();

        }
    }
}
