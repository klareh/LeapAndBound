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
        yield return new WaitForSeconds(delay);
        transform.position = new Vector3(0, 0, -20);
        yield return new WaitForSeconds(delay);
        transform.position = new Vector3(0, 0, -6);
    }

}
