using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrashDetector : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Head"))
        {
            Debug.Log("You crashed!");
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
}
