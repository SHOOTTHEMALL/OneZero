using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;


public class NoMind : Slot, IBeginDragHandler, IEndDragHandler, IDragHandler 
{
    public static Vector2 defaultposition;//드롭하면 다시 원위치로 보내기위한 변수 void Start () { } void Update () { } }

    [SerializeField] private Canvas canvas;

    private RectTransform moveFuck;
    private CanvasGroup canFuck;

    private void Awake()
    {
        moveFuck = GetComponent<RectTransform>();
        canFuck = GetComponent<CanvasGroup>();
    }

    public void OnBeginDrag(PointerEventData eventData)
    {
        //throw new System.NotImplementedException(); 이게 뭐지?
        defaultposition = transform.position;
        canFuck.blocksRaycasts = false;
        canFuck.alpha = .6f;
    }

    public void OnDrag(PointerEventData eventData)
    {
        moveFuck.anchoredPosition += eventData.delta / canvas.scaleFactor;
    }
    public void OnEndDrag(PointerEventData eventData)
    {
        //throw new System.NotImplementedException();
        Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        transform.position = defaultposition;
        canFuck.blocksRaycasts = true;
        canFuck.alpha = 1f;
        //if (eventData.pointerDrag != null)
        //{
        //    transform.position = mousePos; 핸드폰에서 해야한다. 마우스클릭으로 한다. 
        //}
    }
}
