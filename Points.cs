using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Points : MonoBehaviour
{
    AudioSource _audio;

    private void Awake()
    {
        _audio = GetComponent<AudioSource>();
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Player"))
        {
          
            Destroy(gameObject);
            _audio.Play();
        }
    }

}
