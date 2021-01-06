using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Damage : MonoBehaviour
{
    MobileHealthController health;
    private float damageTaken = 10.0f;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag.Equals("BulletEnemy"))
        {
            health.playerHealth -= damageTaken;
            health.UpdateHealth();
        }
    }
}
