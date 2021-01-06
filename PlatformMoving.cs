using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformMoving : MonoBehaviour
{
    float dirX, platformMoveSpeed = 7.0f;
    private bool moveRight = true;

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < 138f)
        {
            moveRight = true;
        }
        if (transform.position.x > 147f)
        {
            moveRight = false;
        }

        if (moveRight)
        {
            transform.position = new Vector2(transform.position.x + platformMoveSpeed * Time.deltaTime, transform.position.y);
        }
        else
        {
            transform.position = new Vector2(transform.position.x - platformMoveSpeed * Time.deltaTime, transform.position.y);
        }

    }
}
