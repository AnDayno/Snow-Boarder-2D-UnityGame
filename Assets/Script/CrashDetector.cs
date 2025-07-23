using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class CrashDetector : MonoBehaviour
{
    [SerializeField] float reloadDelay = 1.5f;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Head"))
        {
            Invoke(nameof(ReloadScene), reloadDelay);
        }
        else if (collision.collider.CompareTag("LeftArm"))
        {
            Debug.Log("You crashed with your left arm!");
        }
        else if (collision.collider.CompareTag("RightArm"))
        {
            Debug.Log("You crashed with your right arm!");
        }
    }

    void ReloadScene()
    {
        SceneManager.LoadScene(0); 
    }
}
