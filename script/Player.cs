using UnityEngine;
using System.Collections;

[RequireComponent(typeof(PlayerController))]
public class Player : MonoBehaviour
{

    public float moveSpd = 5f;
    PlayerController cont;

    void Start()
    {
        cont = GetComponent<PlayerController>();
    }
     
    void Update()
    {
        Vector3 moveInput = new Vector3(Input.GetAxisRaw("Horizontal"), 0, Input.GetAxisRaw("Vertical"));
        Vector3 moveVelocity = moveInput.normalized * moveSpd;
        cont.Move(moveVelocity);
    }

    public void SpeedUp(string Player)
    {
        if (Player == "Player1")
        {
            moveSpd += 5f;
        }
    }

    public void PositionItem(string Player)
    {
        if (Player == "Player1")
        {
            //var MyGameObjectPosition = GameObject.Find("Player1").transform.position;
            //MyGameObjectPosition = new Vector3 (-8, 1, 8);
            //print(MyGameObjectPosition);
            GameObject.Find("Player2").transform.position = new Vector3(8.64f, 0.5f, 8.67f);
        }
    }
}
