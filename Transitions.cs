using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Transitions : MonoBehaviour
{
    ///private GameObject DoubleBarrel;
    public Animator anim;
    Inventory findItem;
    public Inventory inventory1;

    // Update is called once per frame
    void Update()
    {

        //GameObject shotgun;
        // = inventory1.FindItemByType("Health Potion");
        //findItem.FindItem(shotgun);
       
        

        //check if we have shotgun in inventory
      // if (findItem)//function named find item from script inventory.cs
       // {
            //enable shotugn animations       
            if (Input.GetButtonDown("UseShotgun"))
            {
                anim.SetBool("EquipRifle", false);
                anim.SetBool("EquipShotgun", true);
            }
      //  }

        

        if (Input.GetButtonDown("UseRifle"))
        {
            anim.SetBool("EquipShotgun", false);
            anim.SetBool("EquipRifle", true);
        }

    }
}
