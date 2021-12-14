using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MouseCursor : MonoBehaviour
{
    public Image mouseCursor;
    private SpriteRenderer sr;
    private static Camera mainCam;
    //public CanvasGroup noClick;

    private void Awake()
    {
        sr = mouseCursor.GetComponent<SpriteRenderer>();
        //noClick.blocksRaycasts = false;
    }

    // Start is called before the first frame update

    private void OnMouseEnter(Sprite sprite)
    {
        Cursor(sprite);
    }

    private void Update()
    {
            transform.position = GetMouseWorldPos();
        
    }

    private void Cursor(Sprite sprite)
    {
        mouseCursor.gameObject.SetActive(true);
        sr.sprite = sprite;
    }

    private static Vector3 GetMouseWorldPos()
    {
        if (mainCam == null)
        {
            mainCam = Camera.main;
        }
        Vector3 mouseWorldPos = mainCam.ScreenToWorldPoint(Input.mousePosition);
        mouseWorldPos.z = 0f;

        return mouseWorldPos;
    }
}
