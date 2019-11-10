using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    private Rigidbody2D rigidBody;
    public Vector3 velocity = new Vector3(0, 0, 0);

    void Start()
    {
        rigidBody = GetComponent<Rigidbody2D>();

    }

    void Update()
    {
        rigidBody.velocity = velocity;
    }

    private void OnCollisionEnter2D(Collision2D other) {
        Destroy(gameObject);
    }

}
