using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JelmerJump : MonoBehaviour
{
    public bool isGrounded = false;
    public float distanceGround;

    public Vector3 jump;
    public float jumpForce = 1.7f;
    public Rigidbody rb;
    public Vector3 raycast;

    // public GameObject jumpSound;
    // Start is called before the first frame update
    void Start()
    {
        distanceGround = GetComponent<Collider>().bounds.extents.y;

        rb = GetComponent<Rigidbody>();
        jump = new Vector3(0.0f, 1.7f, 0.0f);
        // isGrounded = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            rb.AddForce(jump * jumpForce, ForceMode.Impulse);
            // jumpSound.SetActive(false);
            // jumpSound.SetActive(true);
        }
        if(!Physics.Raycast(transform.position, -Vector3.up, distanceGround + 0.4f))
        {
            isGrounded = false;
            Debug.Log("Aiiiiiiiiiiir");
        }
        else
        {
            isGrounded = true;
            Debug.Log("Groooooooounded");
        }
    }
}