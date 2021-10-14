using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Slot : MonoBehaviour , IDropHandler
{
    public void OnDrop(PointerEventData eventData)
    {
        //throw new System.NotImplementedException();
        if (eventData.pointerDrag != null && gameObject.CompareTag("iP"))//eventData.pointerDrag != null 의 조건은 한번 들어가면 다시 초기화가 안된다. 어카지
        {
            eventData.pointerDrag.GetComponent<RectTransform>().anchoredPosition = GetComponent<RectTransform>().anchoredPosition;//현재 위치를 먹어버림.
            //eventData.pointerDrag.gameObject.transform.position = gameObject.transform.position;
        }
        else if(eventData.pointerDrag != null && gameObject.CompareTag("pI"))
        {
            NoMind.defaultposition = transform.position;
        }
    }
}