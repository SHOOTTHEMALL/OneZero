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
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        adidas += Time.deltaTime;
        time += .0016f;
        if(adidas > 1.5f )
        {
            t1.color = new Color(t1.color.r, t1.color.g, t1.color.b ,time);
        }
    }
}
