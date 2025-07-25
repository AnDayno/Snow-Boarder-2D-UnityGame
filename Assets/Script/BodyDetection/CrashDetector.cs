using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class CrashDetector : MonoBehaviour
{
    [SerializeField] float reloadDelay = 1.5f;
    [SerializeField] ParticleSystem crashEffect;
    [SerializeField] AudioClip crashSFX;
    bool hasCrashed = false;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Obstacle") || collision.collider.CompareTag("Snow"))
        {
            crashEffect.Play();

            if (!hasCrashed)
            {
                hasCrashed = true;
                GetComponent<AudioSource>().PlayOneShot(crashSFX, 0.5f);
                FindObjectOfType<PlayerController>().disableControls();
                Invoke(nameof(ReloadScene), reloadDelay);
            }
        }
    }

    void ReloadScene()
    {
        SceneManager.LoadScene(0); 
    }
}
