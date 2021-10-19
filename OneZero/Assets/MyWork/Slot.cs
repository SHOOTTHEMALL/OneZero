using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Slot : MonoBehaviour , IDropHandler
{
    public GameObject clothes;
    private List<Image> clothe = new List<Image>();

    public GameObject srS;
    private List<SpriteRenderer> sr = new List<SpriteRenderer>();

    public void Awake()
    {
        clothes = GameObject.Find("Meow");
        Debug.Log(clothes);
        clothes.GetComponentsInChildren<Image>(clothe);

        srS = GameObject.Find("clothes");
        srS.GetComponentsInChildren<SpriteRenderer>(sr);
        //sr.RemoveAt(0);
        Debug.Log(sr.Count);
        foreach (var item in sr)
        {
            item.gameObject.SetActive(false);
        }
    }
    public void OnDrop(PointerEventData eventData)
    {

        if(eventData.pointerDrag == clothe[0])
        {
            sr[0].gameObject.SetActive(true);
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