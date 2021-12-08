using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Slot : MonoBehaviour , IDropHandler
{
    public GameObject clothes;
    public List<Image> clothe = new List<Image>();

    public GameObject srS;
    public List<SpriteRenderer> sr = new List<SpriteRenderer>();

    private bool isPerfect;

    //public DataManager DataManager; 초기ㅗ화가된다 씬 을 옮기면 안됨

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
        //if (eventData. != null)
        //{
        //    return;
        //}

        for (int i = 0; i < sr.Count; i++) //들어갔는지를 검사한다.
        {
            if (sr[i].gameObject.activeSelf)
            {
                eventData.pointerDrag.gameObject.SetActive(false);
                return;
            }
        }

        //eventData.pointerDrag.SetActive(false);
        for (int i = 0; i < clothe.Count; i++)
        {
            if(eventData.pointerDrag != null && eventData.pointerDrag.gameObject == clothe[i].gameObject)
            {
                sr[i].gameObject.SetActive(true);
                eventData.pointerDrag.gameObject.SetActive(false);
                DataClass.hisHerat += DataManager.instance.closet.clothes[i].love;
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

    private void Update()
    {
        if(isPerfect)
        {
            if(DataClass.hisHerat>=50)
            {
                SceneManager.LoadScene(5);
            }
            else if (DataClass.hisHerat >= 30)
            {
                SceneManager.LoadScene(6);
            }
            else
            {
                SceneManager.LoadScene(7);
            }
        }
    }

    public void Perfect()
    {
        isPerfect = true;
    }

    //private void getLove()
    //{
    //    DataManager.instance.dataclass.hisHerat++;
    //}

    //private void loseLove()
    //{
    //    DataManager.instance.dataclass.hisHerat--;
    //}
}