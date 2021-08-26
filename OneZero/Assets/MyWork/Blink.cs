using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blink : MonoBehaviour
{
    private float time;

    // Update is called once per frame
    void Update()
    {
        if (time < 1.5f)
        {
            GetComponent<SpriteRenderer>().color = new Color(1, 1, 1, 1 - time);
        }
        else
        {
            GetComponent<SpriteRenderer>().color = new Color(1, 1, 1, time);
            if (time > 1.9f)
            {
                time = 0.3f;
            }
        }

        time += Time.deltaTime;
    }
}
