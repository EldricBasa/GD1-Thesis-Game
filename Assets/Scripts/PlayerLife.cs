using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerLife : MonoBehaviour
{
    private Rigidbody2D rb;
    private Animator anim;
    public GameObject gameOverUI;
    [SerializeField] private AudioSource dieSoundEffect;
    [SerializeField] private AudioSource spikeSoundEffect;
    [SerializeField] private AudioSource lavaSoundEffect;
    [SerializeField] private AudioSource enemySoundEffect;
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("Trap"))
        {
            Die();
            dieSoundEffect.Play();
            spikeSoundEffect.Play();
        }
        if(collision.gameObject.CompareTag("Lava"))
        {
            Die();
            dieSoundEffect.Play();
            lavaSoundEffect.Play();
        }
        if(collision.gameObject.CompareTag("Enemy"))
        {
            Die();
            dieSoundEffect.Play();
            enemySoundEffect.Play();
        }
    }

    private void Die()
    {
        rb.bodyType = RigidbodyType2D.Static;
        gameOver();
        anim.SetTrigger("death");
    }

    private void RestartLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void gameOver() {
        gameOverUI.SetActive(true);
    }
}