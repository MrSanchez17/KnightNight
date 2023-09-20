using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public bool grounded;
    public LayerMask groundLayer;
    public float jumpSpeed;
    private MovementBehavior _mvb;
    private Animator _anim;
    private SpriteRenderer _spr;
    private Vector3 dir;
    public Transform spawn;
    private static int cointCount;
    public Transform NextLevel;
    public Transform Restart;

    private int heal;

    void Start()
    {
        _mvb = GetComponent<MovementBehavior>();
        _anim = GetComponent<Animator>();
        _spr = GetComponent<SpriteRenderer>();

    }

    void Update()
    {
        dir = new Vector3(Input.GetAxis("Horizontal"), 0, 0);

        if (Input.GetKeyDown(KeyCode.Space) && grounded == true)
        {
            _mvb.Jump(jumpSpeed);
            _anim.SetInteger("state", 2);
        }

        if (dir.x > 0)
        {
            _anim.SetInteger("state", 1);
            _spr.flipX = false;
        }
        else if(dir.x < 0)
        {
            _anim.SetInteger("state", 1);
            _spr.flipX = true;
        }


        if (!Input.anyKey)
        { 
            _mvb.StopMovement();
            _anim.SetInteger("state",0);
        }

        RaycastHit2D hit = Physics2D.Raycast(transform.position, Vector2.down, 1.0f, groundLayer);
        if (hit)
            grounded = true;
        else
            grounded = false;
    }

    private void FixedUpdate()
    {
        _mvb.MoveRB(dir);
    }

    public void Spawn()
    {
        gameObject.transform.SetPositionAndRotation(spawn.transform.position, spawn.transform.rotation);
    }

    public void AnimationDie()
    {
        if(heal == 0)
        {
            _anim.SetInteger("state",5);
        }
    }
    
    public void AnimationHurt()
    {
        _anim.SetInteger("state",3);
    }

    public void ChangingCamera()
    {

        Camera.main.transform.SetPositionAndRotation(NextLevel.transform.position, NextLevel.transform.rotation); 
    }

    public void RestAll()
    {
        Camera.main.transform.position = new Vector3(0,0,-10);
        GameObject player = GameObject.Find("Hollow");
        player.transform.SetPositionAndRotation(Restart.transform.position, Restart.transform.rotation);
    }
}
