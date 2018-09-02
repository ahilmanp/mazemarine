using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraItem : MonoBehaviour {

    public GameObject fogofwar;
    public GameObject pickup;

	void OnTriggerEnter(Collider other)
	{
        if(other.CompareTag("Player1"))
        {
            fogofwar.GetComponent<FogOfWarScript>().PowerUp("Player1");

        }	

        if(other.CompareTag("Player2"))
        {
            fogofwar.GetComponent<FogOfWarScript>().PowerUp("Player2");
        }
        Destroy(pickup);
	}

}
