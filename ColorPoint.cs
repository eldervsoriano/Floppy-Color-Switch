using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ColorPoint : MonoBehaviour
{
    public FloppybirdripoffGameManager FloppybirdripoffGameManager;
    public Player playerCharacter;
    public int characterColorState;
    public AudioSource audioSource;

    public void Start()
    {
        FloppybirdripoffGameManager = GameObject.FindObjectOfType<FloppybirdripoffGameManager>();
        playerCharacter = GameObject.FindObjectOfType<Player>();
        audioSource = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter2D(Collider2D target)
    {
        if (target.gameObject.CompareTag("Player"))
        {
            if (playerCharacter.x == characterColorState)
            {
                FloppybirdripoffGameManager.PointAdd();
                audioSource.Play();
                playerCharacter.ColorChanger();
                this.gameObject.GetComponent<SpriteRenderer>().enabled = false;
            }

            else
            {
                playerCharacter.Dead();
            }
        }
    }

}
