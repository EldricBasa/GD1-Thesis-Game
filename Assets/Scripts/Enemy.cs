using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] private AudioSource coinSoundEffect;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("EnemyHead"))
        {
            coinSoundEffect.Play();
            Destroy(collision.gameObject);
            gameObject.GetComponent<Renderer>().enabled = false;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("EnemyHead"))
        {
            coinSoundEffect.Play();
            Destroy(collision.gameObject);
            gameObject.GetComponent<Renderer>().enabled = false;
        }
    }
}
