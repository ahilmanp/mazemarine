using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FinishLine2 : MonoBehaviour
{

    public GameObject playerWinUI;
    public bool FinishPlane = false;

    // Use this for initialization
    void Start()
    {
        FinishPlane = false;

    }

    void OnTriggerEnter(Collider col)
    {
        if (col.tag == "Player2")
        {
            FinishPlane = true;
            playerWinUI.SetActive(true);
            print("yeay Player2");
        }
    }
}