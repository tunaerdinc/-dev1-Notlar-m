using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Engel : MonoBehaviour
{
    Scene _scene;
    private void Awake()
    {
        _scene = SceneManager.GetActiveScene();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
       if (collision.gameObject.CompareTag("Player"))
            {
            SceneManager.LoadScene(_scene.name);
        }
    }
}
