using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Knife : MonoBehaviour
{
    public Button grab;
    public Button nothx;
    public Button grabing;
    private bool isGrab = false;
    public bool youChoose = false;

    private void Awake()
    {
        DontDestroyOnLoad(gameObject);
        grabing.gameObject.SetActive(false);
    }

    private void Update()
    {
        if(isGrab == true)
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
        youChoose = true;
        grab.gameObject.SetActive(false);
        nothx.gameObject.SetActive(false);
    }

    public void Nothx()
    {
        isGrab = false;
        youChoose = true;
        grab.gameObject.SetActive(false);
        nothx.gameObject.SetActive(false);
    }

    public void Kill()
    {
        //Á×ÀÌ´Â ¾ÀÀ¸·Î ³Ñ¾î°¡±â
    }
}
