using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Slot : MonoBehaviour , IDropHandler
{
    public static bool Naruto = false;
    public void OnDrop(PointerEventData eventData)
    {
        //throw new System.NotImplementedException();
        if (eventData.pointerDrag != null && gameObject.CompareTag("iP"))
        {
                eventData.pointerDrag.GetComponent<RectTransform>().anchoredPosition = GetComponent<RectTransform>().anchoredPosition; //현재 위치를 먹어버림.
                Naruto = true;
                //eventData.pointerDrag.gameObject.transform.position = gameObject.transform.position;
        }
        else
            Naruto = false;
    }
}