using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jump : MonoBehaviour
{
    public float jumpSpeed = 5f;

    private Rigidbody2D rigidbody2D;
    private bool isJump = false;

    // Start is called before the first frame update
    void Start()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Jump")) {
            isJump = true;
        }
    }

    private void FixedUpdate() {
        if (isJump) {
            rigidbody2D.AddForce(Vector2.up * jumpSpeed, ForceMode2D.Impulse);
            isJump = false;
        }
    }
}
