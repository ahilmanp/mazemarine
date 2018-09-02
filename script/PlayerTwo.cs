using UnityEngine;
using System.Collections;

[RequireComponent(typeof(PlayerControllerTwo))]
public class PlayerTwo : MonoBehaviour
{

    public float moveSpeed = 7f;
    PlayerControllerTwo controller;

    void Start()
    {
        controller = GetComponent<PlayerControllerTwo>();
    }

    void Update()
    {
        Vector3 moveInput = new Vector3(Input.GetAxisRaw("HorizontalTwo"), 0, Input.GetAxisRaw("VerticalTwo"));
        Vector3 moveVelocity = moveInput.normalized * moveSpeed;
        controller.Move(moveVelocity);
    }
}