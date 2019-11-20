using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exit : MonoBehaviour
{
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
        if (other.gameObject.name == "player")      
            StartCoroutine(nextFloor(other.gameObject, 0.5f));
    }

    IEnumerator nextFloor(GameObject gameObject, float delay)
    {
        Transform transform = gameObject.GetComponent(typeof(Transform)) as Transform;
        Rigidbody2D rigidbody = gameObject.GetComponent(typeof(Rigidbody2D)) as Rigidbody2D;

        yield return new WaitForSeconds(delay);
        rigidbody.bodyType = RigidbodyType2D.Kinematic;
        rigidbody.velocity = new Vector2(0, 5);
        yield return new WaitForSeconds(1);
        rigidbody.velocity = new Vector2(0, 0);
        transform.position = new Vector3(0, 0, -6);
        rigidbody.bodyType = RigidbodyType2D.Dynamic;

    }

}
