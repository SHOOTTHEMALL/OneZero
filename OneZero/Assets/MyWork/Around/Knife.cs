using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Knife : MonoBehaviour
{
    public Button grab;
    public Button nothx;
    public Button grabing;

    private void Awake()
    {
        //DontDestroyOnLoad(gameObject);
    }

    private void Update()
    {
        if(GameManager.instance.isGrab == true)
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
        GameManager.instance.isGrab = true;
        GameManager.instance.youChoose = true;
        grab.gameObject.SetActive(false);
        nothx.gameObject.SetActive(false);
    }

    public void Nothx()
    {
        GameManager.instance.isGrab = false;
        GameManager.instance.youChoose = true;
        grab.gameObject.SetActive(false);
        nothx.gameObject.SetActive(false);
    }

    public void Kill()
    {
        //Á×ÀÌ´Â ¾ÀÀ¸·Î ³Ñ¾î°¡±â
    }
}
