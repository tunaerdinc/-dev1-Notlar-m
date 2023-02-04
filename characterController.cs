using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class characterController : MonoBehaviour
{
    float speed = 0.0f;
    Rigidbody2D r2d;
    Animator _animator;


    private void Start()
    {
        r2d = GetComponent<Rigidbody2D>();
        _animator = GetComponent<Animator>();
        
    }

    private void Update()

    {
        if (Input.GetKey(KeyCode.Space))
        {
            speed = 1.0f;
            Debug.Log(message:"Hiz 1.0f");
        }
        else
        {
            speed = 0.0f;
            Debug.Log(message:"Hiz 0.0f");
        }

        _animator.SetFloat("speed", speed);
        r2d.velocity = new Vector2(speed, 0f);

    }
}

