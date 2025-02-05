using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DilemmaScript : MonoBehaviour
{
    
    void Start()
    {

    }

    void Update()
    {
        float xxnew = Mathf.Sin (Time.time );
        transform.position += new Vector3(xxnew * Time.deltaTime ,transform.position.y ,transform.position.z );
    }
}
