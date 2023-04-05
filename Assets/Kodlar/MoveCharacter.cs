using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCharacter : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.A ) && gameObject.name == "Character")
        {
            transform.position += new Vector3(-10,0,0) * Time.deltaTime ;
        }
        if (Input.GetKey(KeyCode.D) && gameObject.name == "Character")
        {
            transform.position += new Vector3(10, 0,0) * Time.deltaTime;
        }

        if(Input.GetKey(KeyCode.W) && gameObject.name== "Main Camera") 
        { transform.position += new Vector3(0, 0, 3) * Time.deltaTime; }

        if (Input.GetKey(KeyCode.S) && gameObject.name == "Main Camera")
        { transform.position += new Vector3(0, 0, -3) * Time.deltaTime; }
    }
}
