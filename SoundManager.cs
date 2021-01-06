using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public static AudioClip playerJump;
    public static AudioClip playerPickup;
    public static AudioClip playerShoot;
    public static AudioClip playerPowerup;
    public static AudioClip bulletExplode;
    public static AudioClip coinPickupSound;

    static AudioSource audioSrc;

    void Start()
    {
        playerJump = Resources.Load<AudioClip>("Jump2");
        playerPickup = Resources.Load<AudioClip>("Pickup_Coin");
        playerShoot = Resources.Load<AudioClip>("Laser_Shoot");
        playerPowerup = Resources.Load<AudioClip>("Powerup");
        bulletExplode = Resources.Load<AudioClip>("Explosion2");
        coinPickupSound = Resources.Load<AudioClip>("Coin_pickup2");

        audioSrc = GetComponent<AudioSource>();

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public static void PlaySound (string clip)
    {
        switch (clip)
        {
            case "Jump2":
                audioSrc.PlayOneShot(playerJump);
                break;
            case "Pickup_Coin":
                audioSrc.PlayOneShot(playerPickup);
                break;
            case "Laser_Shoot":
                audioSrc.PlayOneShot(playerShoot);
                break;
            case "Powerup":
                audioSrc.PlayOneShot(playerPowerup);
                break;
            case "Explosion2":
                audioSrc.PlayOneShot(bulletExplode);
                break;
            case "coinPickup":
                audioSrc.PlayOneShot(coinPickupSound);
                break;
        }

    }


}
