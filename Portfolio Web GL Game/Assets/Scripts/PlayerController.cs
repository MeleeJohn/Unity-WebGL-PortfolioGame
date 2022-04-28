using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody playerRB;
    public int walkingMod;
    public GameObject playerCamera;
    
    // Start is called before the first frame update
    void Start()
    {
        playerRB = this.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        playerRB.AddForce(-this.transform.up * 0.75f);

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

        this.transform.Rotate(0, Input.GetAxis("Mouse X") * 1.5f, 0);
        playerCamera.transform.Rotate(-Input.GetAxis("Mouse Y") * 1.5f,0,0);
    }
}
