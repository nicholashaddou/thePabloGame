using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletNoSound : MonoBehaviour
{
    public float bulletSpeed = 20f;
    public Rigidbody2D rb;
    public GameObject impactEffect;
    private MobileHealthController healthController;
    private int bulletDamage = 15;

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
        //SoundManager.PlaySound("Explosion2");
        
        Destroy(gameObject);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag.Equals("Player"))
        {
            healthController.playerHealth -= bulletDamage;
            healthController.UpdateHealth();
        }
    }

}
