using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class helloworld : MonoBehaviour
{
    public float speed = 1;
    public float blood = 5;
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
       

        if (Input.GetKey(KeyCode.RightArrow)) {

             
              obj.transform.position += new Vector3(Time.deltaTime*speed, 0, 0);
          
        }

        // Left
        

        if (Input.GetKey(KeyCode.LeftArrow)) {

             
              obj.transform.position -= new Vector3(Time.deltaTime*speed, 0, 0);
            
        }
        // Up
        

        if (Input.GetKey(KeyCode.UpArrow)) {

             
              obj.transform.position += new Vector3(0, Time.deltaTime*speed, 0);
            
        }
        // Down
       
        if (Input.GetKey(KeyCode.DownArrow)) {

             
              obj.transform.position -= new Vector3(0, Time.deltaTime*speed, 0);
           
        }
/////////////////////////////////////////////////////////////////
          // Right + Up
       

        if (Input.GetKey(KeyCode.RightArrow)  && Input.GetKey(KeyCode.UpArrow)) {

             
              obj.transform.position += new Vector3(Time.deltaTime*speed, Time.deltaTime*speed, 0);

        }

        // Left + Up 
        

        if (Input.GetKey(KeyCode.LeftArrow) && Input.GetKey(KeyCode.UpArrow)) {

             
              obj.transform.position += new Vector3( - Time.deltaTime*speed, Time.deltaTime*speed, 0);
   
        }
        // Right + Down
        

        if (Input.GetKey(KeyCode.RightArrow) && Input.GetKey(KeyCode.DownArrow)) {

             
              obj.transform.position += new Vector3(Time.deltaTime*speed, -Time.deltaTime*speed, 0);
      
        }
        // Left + Down
       
        if (Input.GetKey(KeyCode.LeftArrow) && Input.GetKey(KeyCode.DownArrow) ) {

             
              obj.transform.position += new Vector3(-Time.deltaTime*speed, -Time.deltaTime*speed, 0);
           
        }



    }
}


