using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class helloworld : MonoBehaviour
{
    public float speed = 1;
    public Transform obj;
    private float lastTime;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Right
        if (Input.GetKeyDown(KeyCode.RightArrow)){

                lastTime = Time.time;

        }       

        if (Input.GetKey(KeyCode.RightArrow)) {

             
              obj.transform.position += new Vector3((Time.time - lastTime)*speed, 0, 0);
              lastTime = Time.time;
        }

        // Left
        if (Input.GetKeyDown(KeyCode.LeftArrow)){

                lastTime = Time.time;

        }       

        if (Input.GetKey(KeyCode.LeftArrow)) {

             
              obj.transform.position -= new Vector3((Time.time - lastTime)*speed, 0, 0);
              lastTime = Time.time;
        }
    }
}


