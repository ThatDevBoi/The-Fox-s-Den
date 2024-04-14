using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBaseData : MonoBehaviour
{
    protected Rigidbody rb;
    protected CapsuleCollider Collider;
    // Everyting Apart of the Child Parent Prefab Bond
    public Transform playerObj, playerOritnetation, Player;
    public  float speedPowerValue = 10;
    public float rotPowerValue = 5; // Used for rotation

    public void Awake()
    {
        playerComponentSetUp();
    }

    void playerComponentSetUp()
    {
        Collider = GetComponent<CapsuleCollider>();
        rb = GetComponent<Rigidbody>();
        if (rb == null)
        {
            rb = gameObject.AddComponent<Rigidbody>();
            Debug.Log("Adding Rigibody");
        }
        else
        {
            rb = GetComponent<Rigidbody>();
            Debug.Log("Found" + gameObject.name + "RB");
        }

        if (Collider == null)
        {
            Collider = gameObject.AddComponent<CapsuleCollider>();
            Debug.Log("Adding Capsule Collider");
        }
        else
        {
            Collider = GetComponent<CapsuleCollider>();
            Debug.Log("Found" + gameObject.name + "Collider");
        }

        // RB Set Up
        rb.useGravity = false;
        rb.constraints = RigidbodyConstraints.FreezeRotation;
        rb.interpolation = RigidbodyInterpolation.Interpolate;
    }
}
