﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class alpha : MonoBehaviour
{
    public CanvasGroup alpa;
    private float adidas = 0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        adidas += Time.deltaTime;
        if(adidas>6)
        {
            alpa.alpha -= 0.005f;
           // adidas = 0;
        }
        else if(adidas>1.5f)
        {
            alpa.alpha += 0.006f;
        }
    }
}
