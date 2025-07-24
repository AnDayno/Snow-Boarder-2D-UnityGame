using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftArm : MonoBehaviour
{
    Rigidbody2D rb;

    [SerializeField] ParticleSystem bloodTrail;

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Obstacle") || collision.collider.CompareTag("Snow"))
        {
            if (!TryGetComponent<Rigidbody2D>(out rb))
            {
                Debug.Log("You crashed with your left arm!");
                rb = gameObject.AddComponent<Rigidbody2D>();
                rb.bodyType = RigidbodyType2D.Dynamic;
                rb.mass = 0.2f;
                rb.collisionDetectionMode = CollisionDetectionMode2D.Continuous;
                bloodTrail.Play();
            }
        }
    }
}
