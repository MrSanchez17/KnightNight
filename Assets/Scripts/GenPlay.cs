using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenPlay : MonoBehaviour
{
    private MovementBehavior _mvb;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player") )
        {
            PlayEnemyMovement();
        }
    }
    private void PlayEnemyMovement()
    {
        //_mvb.Move();
    }
}