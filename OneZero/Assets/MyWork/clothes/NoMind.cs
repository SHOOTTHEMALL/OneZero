using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;


public class NoMind : MonoBehaviour, IBeginDragHandler, IEndDragHandler, IDragHandler
{
    //public Vector2 defaultposition;//드롭하면 다시 원위치로 보내기위한 변수 void Start () { } void Update () { } }

    [SerializeField] Button btnRroll;
    [SerializeField] private Canvas canvas;

    private RectTransform moveFuck;
    private CanvasGroup canFuck;

    private Slot slot;

    private void Awake()
    {
        moveFuck = GetComponent<RectTransform>();
        canFuck = GetComponent<CanvasGroup>();
        //defaultposition = GetComponent<RectTransform>().anchoredPosition;
        btnRroll.onClick.AddListener(RollBack);
        slot = FindObjectOfType<Slot>();
    }
    
    public void OnBeginDrag(PointerEventData eventData)
    { 
        //throw new System.NotImplementedException(); 이게 뭐지? 일부로 오류를 내는 거래 도라인가봐;;
        //defaultposition = GetComponent<RectTransform>().anchoredPosition;
        //canFuck.blocksRaycasts = false;
        canFuck.alpha = .6f;
    }

    public void OnDrag(PointerEventData eventData)
    {
        moveFuck.anchoredPosition += eventData.delta / canvas.scaleFactor;
    }
    public void OnEndDrag(PointerEventData eventData)
    {
        //throw new System.NotImplementedException();
        //Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        //canFuck.blocksRaycasts = true;
        canFuck.alpha = 1f; //다시 들어갔다가 나올 수 있는 코드다. 
                            //if (eventData.pointerDrag != null)
                            //{
                            //    transform.position = mousePos; //핸드폰에서 해야한다. 마우스클릭으로 한다. 
                            //}
    }

    void RollBack()
    {
        gameObject.SetActive(false);
        gameObject.SetActive(true);
        canFuck.alpha = 1f;
        //canFuck.blocksRaycasts = false;
    }

    public void cantSee()
    {
        for (int i = 0; i < slot.sr.Count; i++)
        {
            slot.sr[i].gameObject.SetActive(false);
        }
    }
}
