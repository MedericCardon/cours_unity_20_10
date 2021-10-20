using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Transform playerTransform { get; set; } = null;

    public float _playerSpeed = 2;

    // pas de ; sur les propriété get / set
    public float playerSpeed { get { return _playerSpeed; } set { _playerSpeed = value; }}

    private Rigidbody rigidbody { get; set; } = null;

    private Vector3 direction { get; set; }= Vector3.zero; // new Vector 3(0,0,0);

    private void Start()
    {
        playerTransform = transform;
        rigidbody = GetComponent<Rigidbody>();
        //rigidbody = GameObject.GetComponent<Rigidbody>();

    }

    private void Update()
    {
        direction = Vector3.zero;
        if (Input.GetButton("Vertical"))
        {
            direction += playerTransform.forward * Time.deltaTime * playerSpeed * Input.GetAxis("Vertical");
        }
        if(Input.GetButton("Horizontal"))
        {
            direction += playerTransform.right * Time.deltaTime * playerSpeed * Input.GetAxis("Horizontal");
        }
    }

    private void FixedUpdate()
    {
        rigidbody.position += direction;
    }
}
