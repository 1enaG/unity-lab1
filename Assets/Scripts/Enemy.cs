using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    private Vector3 temp;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // change size (grow): 
        temp = transform.localScale;
        temp.x += Time.deltaTime;
        temp.y += Time.deltaTime;
        transform.localScale = temp;
        // rotate: 
        transform.Rotate(new Vector3(0, 0, 1), 1); //axis, angle 
        //transform.Rotate(0, 1, 0); 

    }

    
}
