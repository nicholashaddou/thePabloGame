using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInteract : MonoBehaviour
{

    public GameObject currentObject = null;
    public InteractionObject currentInterObjScript = null;
    public Inventory inventory;
    //public MobileHealthController health;
    public Animator animator;
    public bool shotgunInInventory = false;
    public bool hasGun = false;
    

    private void Update()
    {
        if(Input.GetButtonDown("Interact") && currentObject)
        {

            //check if object is to be stored
            if (currentInterObjScript.inventory)
            {

                shotgunInInventory = true;
                animator.SetBool("HaveShotgun", true);
                SoundManager.PlaySound("Pickup_Coin");
                inventory.AddItem(currentObject);
               /* if (currentObject && currentInterObjScript)
                {
                    currentObject = null;
                    currentInterObjScript = null;
                }*/
            }

            if (shotgunInInventory)
            {
                hasGun = true; 
            }

            if(currentInterObjScript.openable)
            {
                if(currentInterObjScript.locked)
                {
                    //check if have object needed
                    if (inventory.FindItem(currentInterObjScript.ItemNeeded))
                    {
                        currentInterObjScript.locked = false;
                    }
                    else
                    {
                        Debug.Log("did not find");
                    }

                } else
                {
                    Debug.Log("Already open");
                }
            }

            currentObject.SendMessage("DoInteraction");                       
           
           /*if (Input.GetButtonDown("UsePotion"))
            {
                Debug.Log("if code runs");
                GameObject potion = inventory.FindItemByType("Health Potion");
                Debug.Log("if code runs");
                if (potion != null)
                {
                    //use then effects
                    Debug.Log("if code runs");
                    //remove from inventory
                    inventory.RemoveItem(potion);
                }
            } //else Debug.Log("else code runs");*/
        }

        //use shotgun (dont forget to move outside if)
       /* if (Input.GetButtonDown("UseShotgun"))
        {
            //check  invent for  item                   
            GameObject guns = inventory.FindItemByType("Shotgun");
            if (guns != null)
            {
                //equip

                //remove IF NECEssary

                //enable animation on animator
                animator.SetBool("UseShotgun", true);
            }

        }*/

        if (Input.GetButtonDown("UsePotion"))
        {
            //Debug.Log("if code runs");          
            SoundManager.PlaySound("Powerup");
            GameObject potion = inventory.FindItemByType("Health Potion");
            Debug.Log("if code runs");
            if (potion != null)
            {
                //use then effects
                Debug.Log("if code runs");

                //health.playerHealth = health.playerHealth + 50; ;
                //remove from inventory
                inventory.RemoveItem(potion);
            }
        }

        if (Input.GetButtonDown("UseTaco"))
        {
            //Debug.Log("if code runs");          
            SoundManager.PlaySound("Powerup");
            GameObject taco = inventory.FindItemByType("HealthPickup");
            Debug.Log("if code runs");
            if (taco != null)
            {
                //use then effects
                Debug.Log("if code runs");

                //health.playerHealth = health.playerHealth + 50; ;
                //remove from inventory
                inventory.RemoveItem(taco);
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Interactible"))
        {
            currentObject = other.gameObject;
            currentInterObjScript = currentObject.GetComponent<InteractionObject>();
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Interactible"))
        {
            if (other.gameObject == currentObject)
            {
                currentObject = null;
            }
            
        }
    }

}
