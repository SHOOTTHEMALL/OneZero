using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Slot : MonoBehaviour , IDropHandler
{
    public GameObject clothes;
    public List<Image> clothe = new List<Image>();

    public GameObject srS;
    public List<SpriteRenderer> sr = new List<SpriteRenderer>();

    public void Awake()
    {
        clothes = GameObject.Find("Meow");
        clothes.GetComponentsInChildren<Image>(clothe);

        srS = GameObject.Find("clothes");
        srS.GetComponentsInChildren<SpriteRenderer>(sr);

        foreach (var item in sr)
        {
            item.gameObject.SetActive(false);
        }
    }
    public void OnDrop(PointerEventData eventData)
    {
        //eventData.pointerDrag.SetActive(false);
        for (int i = 0; i < clothe.Count; i++)
        {
            Debug.Log(sr.Count);
            if(eventData.pointerDrag != null && eventData.pointerDrag.gameObject == clothe[i].gameObject)
            {
                sr[i].gameObject.SetActive(true);
                Debug.Log("나와");
            }
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