using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    public Transform firepoint;
    public GameObject bulletPrefab;
    Animator animator;
    PlayerInteract playerInteract;
    private bool canShoot = false;    
    
    void Update()
    {
        if (GetComponent<PlayerInteract>().hasGun)
        {
            canShoot = true;
        }

        if (Input.GetButtonDown("Fire1") && canShoot)
        {
            Shoot();
        }     
    }

    void Shoot()
    {       
        SoundManager.PlaySound("Laser_Shoot");
        Instantiate(bulletPrefab, firepoint.position, firepoint.rotation);                               
    }
}
