using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FinishLine : MonoBehaviour
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
        if (col.tag == "Player1")
        {
            FinishPlane = true;
            playerWinUI.SetActive(true);
            print("yeay Player1");
        }
    }
}