using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class typeShow : MonoBehaviour
{
    public Text t1;
    public Text t2;

    private float adidas = 0;
    private float time = 0;
    private float time1 = 0;
    private float timeM = 0.8f;
    private float timeM1 = 1;
    // Start is called before the first frame update
    void Start()
    {

        
    }

    // Update is called once per frame
    void Update()
    {
        adidas += Time.deltaTime;
        time += .00060f;
        timeM -= .00030f;
        time1 += .00060f;
        timeM1 -= .00060f;
        if (adidas > 7 )
        {
            t1.color = new Color(t1.color.r, t1.color.g, t1.color.b, timeM);
            Debug.Log(timeM);
            //timeM = 1;
        }
        else if(adidas > 1.5f)
        {
            t1.color = new Color(t1.color.r, t1.color.g, t1.color.b, time);
            Debug.Log(time);
            //time = 0;
        }

        //if(adidas > 13)
        //{
        //    t2.color = new Color(t2.color.r, t2.color.g, t2.color.b, timeM1);
        //    Debug.Log(timeM);
        //}
        //else if(adidas > 7.5f)
        //{
        //    t2.color = new Color(t2.color.r, t2.color.g, t2.color.b, time1);
        //    Debug.Log(time);
        //}
    }
}
