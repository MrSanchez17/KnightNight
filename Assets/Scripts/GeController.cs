using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeController : MonoBehaviour
{
    private MovementBehavior _mvb;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {      
            StopEnemyMovement();
        }
    }

    private void StopEnemyMovement()
    {
        _mvb.StopMovement();
    }
}
