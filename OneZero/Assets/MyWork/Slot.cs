using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Slot : MonoBehaviour , IDropHandler
{
    public Image clothes;
    private List<Image> clothe = new List<Image>();

    public SpriteRenderer srS;
    private List<SpriteRenderer> sr = new List<SpriteRenderer>();

    public void Awake()
    {
        clothes = GameObject.Find("Meow").GetComponent<Image>();
        //clothes.GetComponentInChildren<Image>(clothe);
        clothe.RemoveAt(0);

        srS = GameObject.Find("clothes").GetComponent<SpriteRenderer>();
        //srS.GetComponentInChildren<SpriteRenderer>(sr);
        sr.RemoveAt(0);
    }
    public void OnDrop(PointerEventData eventData)
    {
        if(eventData.pointerDrag == clothe[0])
        {
            
        }
        //throw new System.NotImplementedException();
        //if (eventData.pointerDrag != null)//eventData.pointerDrag != null 의 조건은 한번 들어가면 다시 초기화가 안된다. 어카지
        //{
        //    //eventData.pointerDrag.GetComponent<RectTransform>().anchoredPosition = GetComponent<RectTransform>().anchoredPosition;//현재 위치를 먹어버림.
        //    eventData.pointerDrag.gameObject.transform.position = gameObject.transform.position;
        //}
        //else if(eventData.pointerDrag != null && gameObject.CompareTag("pI"))
        //{
        //    NoMind.defaultposition = transform.position;
        //}
    }
}