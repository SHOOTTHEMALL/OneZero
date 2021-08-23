using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;


public class NoMind : MonoBehaviour, IBeginDragHandler, IEndDragHandler, IDragHandler
{
    public static Vector2 defaultposition;//드롭하면 다시 원위치로 보내기위한 변수 void Start () { } void Update () { } }

    public void OnBeginDrag(PointerEventData eventData)
    {
        //throw new System.NotImplementedException(); 이게 뭐지?
        defaultposition = transform.position;
    }

    public void OnDrag(PointerEventData eventData)
    {
        //throw new System.NotImplementedException();
        Vector2 currentPos = Input.mousePosition; 
        transform.position = currentPos;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        //throw new System.NotImplementedException();
        Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition); 
        transform.position = mousePos;
    }
}
