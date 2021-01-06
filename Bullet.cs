using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// OBSOLETE *** USE BULLET NO SOUND
/// </summary>
public class Bullet : MonoBehaviour
{
    public float bulletSpeed = 20f;
    public Rigidbody2D rb;
    public GameObject impactEffect;

    void Start()
    {
        rb.velocity = transform.right * bulletSpeed;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //Enemy enemy = collision.GetComponent<Enemy>();
        /*if (enemy != null)
        {
            enemy.TakeDamage();
        }*/
      

        Instantiate(impactEffect, transform.position, transform.rotation);
        //play audio for  impact effect
        SoundManager.PlaySound("Explosion2");
        
        Destroy(gameObject);
    }
}
