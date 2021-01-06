using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnakeDamage : MonoBehaviour
{
    public GameObject coin;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag.Equals("Bullet"))
        {
            Instantiate(coin, transform.position, Quaternion.identity);
            ScoreScript.scoreValue += 10;
            gameObject.SetActive(false);
        }
    }

}
