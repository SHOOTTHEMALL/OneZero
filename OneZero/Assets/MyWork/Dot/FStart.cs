using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FStart : MonoBehaviour
{
    public Image eye;

    // Update is called once per frame
    void Update()
    {
        Color color = eye.color;
        if (color.a > 0)
        {
            color.a -= Time.deltaTime/10;
        }

        eye.color = color;
    }
}
