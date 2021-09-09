using System.Collections;
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
        if(adidas>4)
        {
            alpa.alpha += 0.01f;
           // adidas = 0;
        }
    }
}
