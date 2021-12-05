using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Knife : MonoBehaviour
{
    public Button grab;
    public Button nothx;
    private bool isGrab = false;

    public void getKnife()
    {
        isGrab = true;
    }

    public void Nothx()
    {
        isGrab = false;
    }
}
