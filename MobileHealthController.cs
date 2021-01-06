using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MobileHealthController : MonoBehaviour
{
    public float playerHealth;
    [SerializeField] private Text healthText;
    PlayerMovement playerMovement;
    RestartButtonScript restartButtonScript;
    //PlayerMovement playerMovementHealth;

    private void Start()
    {
        UpdateHealth();
    }

    public void UpdateHealth()
    {
        healthText.text = playerHealth.ToString("0");
    }

    /*public void killPlayerOnHealth()
    {
        if (playerHealth <= 0)
        {
            playerMovementHealth.gameOverText.SetActive(true);
            playerMovementHealth.restartButton.SetActive(true);
            gameObject.SetActive(false);
        }
    }*/

    public void Update()
    {
        //set maximum health
        if (playerHealth > 100)
        {            
            playerHealth = 100;
            UpdateHealth();
        }

        if (playerHealth <0)
        {
            playerHealth = 0;
            UpdateHealth();
        }
               
    }

}
