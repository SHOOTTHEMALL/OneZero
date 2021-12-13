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
        Debug.Log(hurt);
        if(hurt >16)
        {
            Debug.Log("사망");
            //여기서 히로인 죽인 엔딩
        }
    }
}
