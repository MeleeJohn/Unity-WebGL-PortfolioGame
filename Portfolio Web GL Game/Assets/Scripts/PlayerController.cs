using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class PlayerController : MonoBehaviour
{
    private Rigidbody playerRB;
    public int walkingMod;
    public GameObject playerCamera;
    public int mouseSensitivity;
    public float cameraRotY;
    public float playerRotX;
    
    // Start is called before the first frame update
    void Start()
    {
        playerRB = this.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        //playerRB.AddForce(-this.transform.up * 2f);

        if (Input.GetKey(KeyCode.W) && playerRB.velocity.magnitude < 10f)
        {
            playerRB.AddForce(this.transform.forward * walkingMod);
        }

        if (Input.GetKey(KeyCode.S) && playerRB.velocity.magnitude < 10f)
        {
            playerRB.AddForce(-this.transform.forward * walkingMod);
        }

        if (Input.GetKey(KeyCode.D) && playerRB.velocity.magnitude < 10f)
        {
            playerRB.AddForce(this.transform.right * walkingMod);
        }

        if (Input.GetKey(KeyCode.A) && playerRB.velocity.magnitude < 10f)
        {
            playerRB.AddForce(-this.transform.right * walkingMod);
        }

        //Player Left-Right rotation
        //this.transform.Rotate(0, Input.GetAxis("Mouse X") * mouseSensitivity, 0);
        playerRotX += Input.GetAxis("Mouse X") * mouseSensitivity;
        transform.rotation = Quaternion.Euler(0f, playerRotX, 0f);

        //Player camera Up-Down look
        cameraRotY += -Input.GetAxis("Mouse Y") * mouseSensitivity;
        cameraRotY = Mathf.Clamp(cameraRotY, -60f, 60f);
        playerCamera.transform.localRotation = Quaternion.Euler(cameraRotY, 0f, 0f);
              
    }

}
