using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Room : MonoBehaviour
{

    public GameObject VecturalCam;

    private void OnTriggerEnter2D(Collider2D Yes)
    {
        if(Yes.CompareTag("Player") && !Yes.isTrigger)
        {
            VecturalCam.SetActive(true);
        }
    }

    private void OnTriggerExit2D(Collider2D Yes)
    {
        if (Yes.CompareTag("Player") && !Yes.isTrigger)
        {
            VecturalCam.SetActive(false);
        }
    }
}
