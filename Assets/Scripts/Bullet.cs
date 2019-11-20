using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    private Rigidbody2D rigidBody;
    public Vector3 velocity = new Vector3(0, 0, 0);
    public Animator animator;

    void Start()
    {
        rigidBody = GetComponent<Rigidbody2D>();

    }

    void Update()
    {
        rigidBody.velocity = velocity;
    }

    private void OnCollisionEnter2D(Collision2D other) {
        Debug.Log("collision2");
        velocity = new Vector3(0, 0, 0);
        StartCoroutine(destroy(0.5f));
        animator.SetBool("isCollided", true);
    }

    IEnumerator destroy(float delay)
    {
        Debug.Log("start " + delay);
        yield return new WaitForSeconds(delay);
        Destroy(gameObject);
        Debug.Log("stop");
    }

}
