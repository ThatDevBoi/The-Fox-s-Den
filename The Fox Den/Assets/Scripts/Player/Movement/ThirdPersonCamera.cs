using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThirdPersonCamera : PlayerBaseData
{

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 viewDir = Player.position - new Vector3(transform.position.x, Player.position.y, transform.position.z);
        playerOritnetation.forward = viewDir.normalized;

        float HInput = Input.GetAxis("Horizontal");
        float VInput = Input.GetAxis("Vertical");
        Vector3 inputDir = playerOritnetation.forward * VInput + playerOritnetation.right * HInput;

        if (inputDir != Vector3.zero)
            playerObj.forward = Vector3.Slerp(playerObj.forward, inputDir.normalized, Time.deltaTime * rotPowerValue);
    }
}
