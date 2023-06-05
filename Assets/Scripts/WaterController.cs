using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterController : MonoBehaviour
{
    
    public GameObject ball;
    public Transform point;
    
    void Start()
    {
        
    }

    
    void FixedUpdate()
    {
        
        if (Input.GetMouseButtonUp(0))
        {
            GameObject obj_ = Instantiate(ball, point.position, point.rotation);
            obj_.GetComponent<Rigidbody2D>().AddForce(obj_.transform.up * 10f, ForceMode2D.Impulse);
            
        }
        
        
    }
   
}
