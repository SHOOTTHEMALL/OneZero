using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FStart : MonoBehaviour
{
    public CanvasGroup a;
    public float time = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        time *= Time.deltaTime;
        if(time >5)
        {
            a.alpha = .02f;
        }
    }
}
