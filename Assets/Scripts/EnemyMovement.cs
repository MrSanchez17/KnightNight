using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{

    private SpriteRenderer _spr;
    private Rigidbody2D rb;
    private MovementBehavior _mvb;
    private Vector3 dir;

    private void Start()
    {
        dir = new Vector3(0.5f, 0, 0);
        rb = GetComponent<Rigidbody2D>();
        _spr = GetComponent<SpriteRenderer>();
        _mvb = GetComponent<MovementBehavior>();
    }

    public void Update()
    {
        _mvb.Move(dir);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer == LayerMask.NameToLayer("Player"))
        {
            return;
        }

        transform.localScale = new Vector3(-1 * transform.localScale.x, transform.localScale.y, transform.localScale.z);
        dir.x = dir.x * -1;
    }

    public void StopMove()
    {
        enabled = false;
        Debug.Log ("0 movimiento"); 
    }

    public void PlayMove()
    {
        enabled = true;
        Debug.Log ("en movimiento"); 
    }
}

