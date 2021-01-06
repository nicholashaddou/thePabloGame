using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StaticWeapon : MonoBehaviour
{
    public Transform firepointstatic;
    public GameObject bulletPrefab;
    public GameObject player;
    Weapon weapon;
    private bool gun = true;

    void Start()
    {
        //Start the coroutine we define below named ExampleCoroutine.
        StartCoroutine(ExampleCoroutine());
    }

    
    IEnumerator ExampleCoroutine()
    {
        while (gun)
        {
            yield return new WaitForSeconds(.75f);
            Instantiate(bulletPrefab, firepointstatic.position, firepointstatic.rotation);
        }                                
    }

}
