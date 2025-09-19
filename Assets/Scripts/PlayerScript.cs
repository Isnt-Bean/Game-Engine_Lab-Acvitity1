using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    // Update is called once per frame
    public float moveSpeed = 5f;
    public float jumpPower = 5f;
    public Rigidbody rb;
    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        Vector3 movement = new Vector2(horizontalInput, verticalInput) * moveSpeed * Time.deltaTime;
        transform.Translate(movement);

    }
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Food"))
        {
            //scale X and Z up by * 1.1
            rb.transform.localScale += new Vector3(0.1f, 0.1f, 0.1f);
        }
    }
}
