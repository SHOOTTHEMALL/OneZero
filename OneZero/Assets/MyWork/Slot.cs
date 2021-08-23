using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Slot : MonoBehaviour , IDropHandler 
{
    public void OnDrop(PointerEventData eventData)
    {
        //throw new System.NotImplementedException();
        if (eventData.pointerDrag != null)
        {
            //eventData.pointerDrag.GetComponent<RectTransform>().anchoredPosition = GetComponent<RectTransform>().anchoredPosition; //현재 위치를 먹어버림.
            
            Debug.Log("왜안되노 이거");
        }
    }
}
