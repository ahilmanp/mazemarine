using UnityEngine;
using System.Collections;

[RequireComponent(typeof(PlayerControllerTwo))]
public class PlayerTwo : MonoBehaviour
{

    public float moveSpd = 5f;
    PlayerControllerTwo cont;

    void Start()
    {
        cont = GetComponent<PlayerControllerTwo>();
    }

    void Update()
    {
        Vector3 moveInput = new Vector3(Input.GetAxisRaw("HorizontalTwo"), 0, Input.GetAxisRaw("VerticalTwo"));
        Vector3 moveVelocity = moveInput.normalized * moveSpd;
        cont.Move(moveVelocity);
    }

    public void SpeedUp(string Player)
    {
        if (Player == "Player2")
        {
            moveSpd += 5f;
        }
    }

    public void PositionItem(string Player)
    {
        if (Player == "Player2")
        {
            //var MyGameObjectPosition = GameObject.Find("Player1").transform.position;
            //MyGameObjectPosition = new Vector3 (-8, 1, 8);
            //print(MyGameObjectPosition);
            GameObject.Find("Player1").transform.position = new Vector3(-8.45f, 0.5f, 8.67f);
        }
    }
}
