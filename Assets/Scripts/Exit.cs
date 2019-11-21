using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exit : MonoBehaviour
{

    public Animator animator;
    public Animator doorAnimator;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    }

    private void OnTriggerEnter2D(Collider2D other) 
    {
        if (other.gameObject.name == "player") {
            StartCoroutine(nextFloor(other.gameObject));
            animator.SetBool("isStartTransition", true);
            doorAnimator.SetBool("isStartClosed", true);
        }
    }

    IEnumerator nextFloor(GameObject gameObject)
    {
        Transform transform = gameObject.GetComponent(typeof(Transform)) as Transform;
        Rigidbody2D rigidbody = gameObject.GetComponent(typeof(Rigidbody2D)) as Rigidbody2D;

        yield return new WaitForSeconds(0.5f);
        rigidbody.bodyType = RigidbodyType2D.Kinematic;
        transform.position = new Vector3(0, 0, 6);
        yield return new WaitForSeconds(2.08f);
        transform.position = new Vector3(0, 0.5f, -6);
        rigidbody.velocity = new Vector2(0, -2);
        yield return new WaitForSeconds(0.25f);
        rigidbody.velocity = new Vector2(0, 0);

        rigidbody.bodyType = RigidbodyType2D.Dynamic;

    }

}
