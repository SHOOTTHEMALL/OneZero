using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class Move : MonoBehaviour
{
    private void Update()
    {
        if(gameObject.CompareTag("One"))
        {
            transform.DOMoveX(7, 2);
        }
        else if(gameObject.CompareTag("Zero"))
        {
            transform.DOMoveX(-6.5f, 2);
        }
        else if (gameObject.CompareTag("Up"))
        {
            transform.DOMoveY(-3.3f, 2);
        }
    }
}
