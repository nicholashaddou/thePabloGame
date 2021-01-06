using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private MobileHealthController healthController;

    public class PlayerStats
    {
        public float playerHealth = 100.0f;
    }

    public PlayerStats playerStats = new PlayerStats();

    private void PlayerDamage(int damage)
    {
        playerStats.playerHealth -= damage;
    }

   /* private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag.Equals("BulletEnemy"))
        {
            PlayerDamage(10);
            //healthController.UpdateHealth();
        }
    }
    private void Update()
    {
        //healthController.UpdateHealth();
    }*/

}
