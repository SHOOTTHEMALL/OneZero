using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KillAngle : MonoBehaviour
{
    private int hurt = 0;
    public GameObject blood;
    public GameObject wo;
    public GameObject love;
    public void Knife()
    {
        hurt++; 
        Debug.Log(hurt);
        if(hurt >16)
        {
            Debug.Log("사망");
            love.SetActive(true);
            //여기서 히로인 죽인 엔딩
        }
        if(hurt>5)
        {
            blood.SetActive(true);
            wo.SetActive(true);
        }
    }
}
