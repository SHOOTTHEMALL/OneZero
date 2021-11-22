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

    private float second = 0f;

    void Update()
    {
        second += Time.deltaTime;
        Debug.Log(second);
        if(second>7)
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
        
        if(second>22)
        {
            ps.gameObject.SetActive(false);
        }
        else if(second>15.5f)
        {
            ps.gameObject.SetActive(true);
            ps.startSpeed -= .005f;
        }
    }
}
