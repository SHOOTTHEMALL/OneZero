using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Follow : MonoBehaviour
{
    private void Awake()
    {
        transform.DOMoveX(0.73f, 2);
    }
}
