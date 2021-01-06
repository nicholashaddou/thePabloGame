using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractionObject : MonoBehaviour
{
    public bool inventory;
    public bool openable;
    public bool locked;
    public GameObject ItemNeeded;
    public string itemType;

   public void DoInteraction()
    {
        gameObject.SetActive(false);
    }
}
