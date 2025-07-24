using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class DustTrail : MonoBehaviour
{
    [SerializeField] ParticleSystem dustTrail;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.collider.CompareTag("Snow"))
        {
            dustTrail.Play();
        }
    }
    void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Snow"))
        {
            dustTrail.Stop();
        }   
    }
}
