﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Around : MonoBehaviour
{
    public float Speed;

    Rigidbody2D rg;
    float h;
    float v;

    bool isHorizonMove;

    Vector3 dirVec;

    GameObject Obj;

    public GameManager manager;
    private void Awake()
    {
        rg = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        h = manager.show ? 0 : Input.GetAxisRaw("Horizontal");
        v = manager.show ? 0 : Input.GetAxisRaw("Vertical");

        bool hDown = manager.show ? false : Input.GetButtonDown("Horizontal");
        bool vDown = manager.show ? false : Input.GetButtonDown("Vertical");
        bool hUp = manager.show ? false : Input.GetButtonUp("Horizontal");
        bool vUP = manager.show ? false : Input.GetButtonUp("Vertical");

        if (hDown || vUP)
            isHorizonMove = true;
        else if (vDown || hUp)
            isHorizonMove = false;

        if (vDown && v == 1)
            dirVec = Vector3.up;
        else if (vDown && v == -1)
            dirVec = Vector3.down;
        else if (hDown && h == -1)
            dirVec = Vector3.left;
        else if (hDown && h == 1)
            dirVec = Vector3.right;

        if (Input.GetButtonDown("Jump") && Obj != null)
            manager.Action(Obj);
    }

    private void FixedUpdate()
    {
        Vector2 move = isHorizonMove ? new Vector2(h, 0) : new Vector2(0, v);
        rg.velocity = move * Speed;

        //sibal Ray
        Debug.DrawRay(rg.position, dirVec * 3, new Color(0, 0, 1));
        RaycastHit2D Hit = Physics2D.Raycast(rg.position, dirVec, 4, LayerMask.GetMask("Objection"));

        if (Hit.collider != null)
        {
            Obj = Hit.collider.gameObject;
        }
        else
            Obj = null;
    }
}