using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

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
    public GameObject boy;
    private void Awake()
    {
        rg = GetComponent<Rigidbody2D>();
        manager = FindObjectOfType<GameManager>();
        boy = GameObject.Find("Man");
    }

    private void Update()
    {
        h = manager.show ? 0 : Input.GetAxisRaw("Horizontal");
        //v = manager.show ? 0 : Input.GetAxisRaw("Vertical"); //횡스크롤로 

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
        Debug.DrawRay(rg.position, dirVec * 9, new Color(1, 0, 1));
        RaycastHit2D Hit = Physics2D.Raycast(rg.position, dirVec, 9, LayerMask.GetMask("Objection"));

        if (Hit.collider != null)
        {
            Obj = Hit.collider.gameObject;
        }
        else
            Obj = null;
    }

    private void OnCollisionEnter2D(Collision2D pal)
    {
        if(pal.gameObject.CompareTag("destiny"))
        {
            boy.SetActive(true);
            boy.transform.DOMoveX(5,3);
        }
    }
}
