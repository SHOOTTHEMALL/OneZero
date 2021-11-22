using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraShake : MonoBehaviour
{
    public Transform camTransform;

    public float shake = 1.5f;

    public float shakeAmout = 1f;
    public float decreaseFactor = 1f;

    Vector3 originalPos;

    private void Awake()
    {
        if (camTransform == null)
            camTransform = GetComponent(typeof(Transform)) as Transform;
    }

    private void OnEnable()
    {
        originalPos = camTransform.localPosition;
    }
    // Update is called once per frame
    void Update()
    {
        if(shake > 0)
        {
            camTransform.localPosition = originalPos + Random.insideUnitSphere * shakeAmout;

            shake -= Time.deltaTime * decreaseFactor;
        }
        else
        {
            shake = 0f;
            camTransform.localPosition = originalPos;
        }
    }
}
