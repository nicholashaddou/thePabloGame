using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthPickup : MonoBehaviour
{
    MobileHealthController healthPlayer;
    public float healthBonus = 15.0f;

    private void Awake()
    {
        healthPlayer = FindObjectOfType<MobileHealthController>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (healthPlayer.playerHealth < 100)
        {
            SoundManager.PlaySound("Powerup");
            healthPlayer.playerHealth += healthBonus;
            healthPlayer.UpdateHealth();
            Destroy(gameObject);
        }
    }

}
