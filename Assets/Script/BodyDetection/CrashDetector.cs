using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class CrashDetector : MonoBehaviour
{
    [SerializeField] float reloadDelay = 1.5f;
    [SerializeField] ParticleSystem crashEffect;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Obstacle") || collision.collider.CompareTag("Snow"))
        {
            crashEffect.Play();
            Invoke(nameof(ReloadScene), reloadDelay);
        }
    }

    void ReloadScene()
    {
        SceneManager.LoadScene(0); 
    }
}
