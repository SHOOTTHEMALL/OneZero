using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Knife : MonoBehaviour
{
    public Button grab;
    public Button nothx;
    public bool isGrab;
    public Button grabing;

    private void Awake()
    {
        DontDestroyOnLoad(gameObject);
        grab = GameObject.Find("Grab").GetComponent<Button>();
        nothx = GameObject.Find("Nothx").GetComponent<Button>();
        if(grab!= null && nothx != null)
        {
            grab.gameObject.SetActive(false);
            nothx.gameObject.SetActive(false);
        }

    }

    private void Update()
    {
        if (isGrab == true)
        {
            grabing.gameObject.SetActive(true);
        }
        else
        {
            grabing.gameObject.SetActive(false);
        }
    }

    public void getKnife()
    {
        isGrab = true;
        GameManager.instance.youChoose = true;
        grab.gameObject.SetActive(false);
        nothx.gameObject.SetActive(false);
        GameManager.instance.isGrabb = true;
    }

    public void Nothx()
    {
        isGrab = false;
        GameManager.instance.youChoose = true;
        grab.gameObject.SetActive(false);
        nothx.gameObject.SetActive(false);
        GameManager.instance.isGrabb = false;
    }
}
