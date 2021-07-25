using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class MoveThem : MonoBehaviour
{
    private void Awake()
    {
        transform.DOMoveX(-1.3f, 5);
    }
}
