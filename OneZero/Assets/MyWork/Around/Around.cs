﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Around : MonoBehaviour
{
    public float Speed;

    Rigidbody2D rg;
    public Transform rayposition;
    float h;

    bool isWalk;
    public Animator player;

    Vector3 dirVec;
    Vector3 moveVec;

    GameObject Obj;

    public GameManager manager;
    private void Awake()
    {
        rg = GetComponent<Rigidbody2D>();
        manager = FindObjectOfType<GameManager>();
        player = GetComponent<Animator>();
    }

    private void Update()
    {
        h = Input.GetAxisRaw("Horizontal");
        //v = manager.show ? 0 : Input.GetAxisRaw("Vertical"); //횡스크롤로 

        //bool hDown = manager.show ? false : Input.GetButtonDown("Horizontal");
        //bool vDown = manager.show ? false : Input.GetButtonDown("Vertical");
        //bool hUp = manager.show ? false : Input.GetButtonUp("Horizontal");
        //bool vUP = manager.show ? false : Input.GetButtonUp("Vertical");

        if(!manager.show)
        {
            if(h < 0)
            {
                //moveVec = Vector3.left;
                dirVec = Vector3.left;
                //isWalk = true;
            }
            else if(h>0)
            {
                moveVec = Vector3.right;
                dirVec = Vector3.right;
                isWalk = true;
            }
            else
            {
                moveVec = Vector3.zero;
                isWalk = false;
            }
        }
        else
        {
            moveVec = Vector3.zero;
            isWalk = false;
        }


        if (Input.GetButtonDown("Jump") && Obj != null)
            manager.Action(Obj);

        player.SetBool("isWalk", isWalk);
    }

    private void FixedUpdate()
    {
        //Vector2 move = isHorizonMove ? new Vector2(h, 0) : new Vector2(0, v);
        rg.velocity = moveVec * Speed;

        //sibal Ray
        Debug.DrawRay(rayposition.position, dirVec * 9, new Color(1, 0, 1));
        RaycastHit2D Hit = Physics2D.Raycast(rayposition.position, dirVec, 9, LayerMask.GetMask("Objection"));

        if (Hit.collider != null)
        {
            Obj = Hit.collider.gameObject;
        }
        else
            Obj = null;
    }
}
