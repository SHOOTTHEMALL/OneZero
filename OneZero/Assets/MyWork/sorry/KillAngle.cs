using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KillAngle : MonoBehaviour
{
    private int hurt = 0;
    public GameObject blood;
    public GameObject wo;
    public void Knife()
    {
        hurt++;
        blood.SetActive(true);
        wo.SetActive(true);
        Debug.Log(hurt);
        if(hurt >16)
        {
            Debug.Log("���");
            Application.Quit();
            //���⼭ ������ ���� ����
        }
    }
}
