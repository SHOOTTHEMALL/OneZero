using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Note : MonoBehaviour
{
    public float mobSpeed = 0;
    public Vector2 StartPosition;
    public void OnEnable()
    {
        transform.position = StartPosition;
    }
    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.left * Time.deltaTime * mobSpeed);

        if (transform.position.x < -10)
        {
            gameObject.SetActive(false);
        }
    }
}
