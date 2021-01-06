﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinScript : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag.Equals("Player"))
        {
            ScoreScript.scoreValue += 10;
            SoundManager.PlaySound("coinPickup");
            Destroy(gameObject);
        }
    }
}
