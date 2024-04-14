using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using Cinemachine;
public class PC_3D_Locomotion : PlayerBaseData
{
    [Header("Movement")]
    Vector3 movementDirection;
    float H, V;
    public bool isMoving = false;

    // Start is called before the first frame update
    private void Awake()
    {
        base.Awake();
    }

    // Update is called once per frame
    void Update()
    {
        Movement();

    }

    void Movement()
    {
        H = Input.GetAxis("Horizontal");
        V = Input.GetAxis("Vertical");

        if (rb.velocity.magnitude == 0)
            isMoving = false;
        else
            isMoving = true;

        // Get the forward direction of the player object (playerObj)
        Vector3 playerForward = playerObj.forward;

        // Calculate movement direction based on player's forward direction
        movementDirection = (playerForward * V) + (transform.right * H);

        movementDirection = movementDirection.normalized * speedPowerValue;

        rb.velocity = movementDirection;
    }
}
