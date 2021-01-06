using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpDownDamage : MonoBehaviour
{
    private Vector3 positionA;
    private Vector3 positionB;
    private Vector3 nextPos;
    [SerializeField] private float moveSpeed = 7.0f;
    [SerializeField] private Transform transform;
    [SerializeField] private Transform transformB;

    private void Start()
    {
        positionA = transform.localPosition;
        positionB = transformB.localPosition;
        nextPos = positionB;
    }
    private void Update()
    {
        Move();
    }
    private void Move()
    {
        transform.localPosition = Vector3.MoveTowards(transform.localPosition, nextPos, moveSpeed * Time.deltaTime); 
        if (Vector3.Distance(transform.localPosition, nextPos) <= 0.2)
        {
            changeDirection();
        }
    }
    private void changeDirection()
    {
        nextPos = nextPos != positionA ? positionA : positionB;
    }
}
