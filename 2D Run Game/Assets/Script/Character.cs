using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
[RequireComponent(typeof(CapsuleCollider2D))]
[RequireComponent(typeof(Animator))]

public class Character : MonoBehaviour
{
    private bool flag = false;
    [SerializeField] private float jumpPower = 500;
    private Rigidbody2D rigidBody;


    void Start()
    {
        rigidBody = GetComponent<Rigidbody2D>();
    }

    
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            flag = true;
        }
    }

    private void FixedUpdate()
    {
        if(flag == true)
        {
            flag = false;

            rigidBody.AddForce(Vector2.up * jumpPower * Time.fixedDeltaTime ,ForceMode2D.Impulse);
            
        }
    }
}
