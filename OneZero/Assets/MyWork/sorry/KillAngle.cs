using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KillAngle : MonoBehaviour
{
    private int hurt = 0;
    public void Knife()
    {
        hurt++;
        if(hurt >16)
        {
            Debug.Log("���");
            //���⼭ ������ ���� ����
        }
    }
}
