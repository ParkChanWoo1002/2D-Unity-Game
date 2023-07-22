using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
[RequireComponent(typeof(CapsuleCollider2D))]
[RequireComponent(typeof(Animator))]

public class Character : MonoBehaviour
{
    private bool flag = false;
    private Rigidbody2D rigidBody;
    private Animator animator;

        
    private IState state = null;  //참조변수 주소값저장 // state = new Run(); 로 참조할수있게 객체 생성

    private void SwitchState(IState state)
    {
        this.state = state;
        this.state.Action(animator,rigidBody);
    }


    void Start()
    {
        animator = GetComponent<Animator>();
        rigidBody = GetComponent<Rigidbody2D>();

        SwitchState(new Run());
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
            SwitchState(new Jump());
            flag = false;
           /* SwitchState(new Run());*/
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Death Zone"))
        {
            
            SwitchState(new Die());
        }
    }
}
