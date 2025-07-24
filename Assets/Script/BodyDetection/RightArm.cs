using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RightArm : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Obstacle") || collision.collider.CompareTag("Snow"))
        {
            Debug.Log("You crashed with your right arm!");
        }
    }
}
