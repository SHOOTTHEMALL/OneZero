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
    }

    public void Nothx()
    {
        isGrab = false;
        GameManager.instance.youChoose = true;
        grab.gameObject.SetActive(false);
        nothx.gameObject.SetActive(false);
    }
}
