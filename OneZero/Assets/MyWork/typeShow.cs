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
        float a = ps.shape.radius;
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
        
        if(second>15.5f)
        {
            a -= .01f;
        }
    }
}
