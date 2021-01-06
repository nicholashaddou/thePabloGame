using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StaticWeaponTurret : MonoBehaviour
{
    public Transform firepointstatic;
    public GameObject bulletPrefab;
    public GameObject player;   

    void Start()
    {
        //Start the coroutine we define below named ExampleCoroutine.
        StartCoroutine(ExampleCoroutine());
    }


    IEnumerator ExampleCoroutine()
    {
        while (true)
        {
            yield return new WaitForSeconds(.25f);
            Instantiate(bulletPrefab, firepointstatic.position, firepointstatic.rotation);
        }
    }

}
