using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MobileDamageController : MonoBehaviour
{
    [SerializeField] private float flowerDamage;
    [SerializeField] private float turretDamage;
    [SerializeField] private MobileHealthController healthController;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player"))
        {
            Damage();
        }
    }

    public void Damage()
    {
        healthController.playerHealth -= flowerDamage;
        healthController.UpdateHealth();
        //if want to turn off object after impact
        //this.gameObject.SetActive(false);
    }

}
