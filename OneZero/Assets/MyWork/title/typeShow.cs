using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class typeShow : MonoBehaviour
{
    public CanvasGroup cg;
    public CanvasGroup cg1;
    public ParticleSystem ps;
    public ParticleSystem pss;
    public Image getOut;

    private float second = 0f;

    void Update()
    {
        second += Time.deltaTime;
        Color color = getOut.color;
        //Debug.Log(second);
        if (second>7)
        {
            cg.alpha -= .006f;
        }
        else if(second>1.5f)
        {
            cg.alpha += .006f;
        }

        if(second > 14)
        {
            cg1.alpha -= .006f;
        }
        else if(second > 8.5f)
        {
            cg1.alpha += .006f;
        }
        
        if(second>22 && color.a >0)
        {
            color.a -= Time.deltaTime / 10;
            ps.gameObject.SetActive(false);
            pss.gameObject.SetActive(true);
        }
        else if(second>15.5f && second<22)
        {
            ps.gameObject.SetActive(true);
            ps.startSpeed -= .005f;
        }
        getOut.color = color;
    }
}
