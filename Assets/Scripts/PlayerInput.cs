using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    private PlayerMovement playerMovement;

    void Awake()
    {
        playerMovement = GetComponent<PlayerMovement>();
    }

    void Update()
    {
        Vector2 moveInput = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
        playerMovement.SetInput(moveInput);

        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            playerMovement.speed = 3;
            playerMovement.maxSpeed = 5;
            playerMovement.acceleration = 6;
            playerMovement.deceleration = 5;
            playerMovement.pullDampening = 10;
            playerMovement.useAcceleration = true;
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            playerMovement.speed = 5;
            playerMovement.maxSpeed = 5;
            playerMovement.pullDampening = 2;
            playerMovement.useAcceleration = false;
        }
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            playerMovement.speed = 3;
            playerMovement.maxSpeed = 10;
            playerMovement.acceleration = 2;
            playerMovement.deceleration = 2;
            playerMovement.pullDampening = 20;
            playerMovement.useAcceleration = true;
        }
        if (Input.GetKeyDown(KeyCode.Q))
        {
            playerMovement.PullTowards(-gameObject.transform.right, 1);
        }
        if (Input.GetKeyDown(KeyCode.E))
        {
            playerMovement.PullTowards(gameObject.transform.right, 1);
        }
    }
}
