using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterController : MonoBehaviour
{
    
    public GameObject ball;
    public GameObject base_;
    public Transform point;
    Vector2 startPoint;
    Vector2 endPoint;
    void Start()
    {
        
    }

    
    void FixedUpdate()
    {
        if (Input.GetMouseButtonDown(0))
        {
            startPoint = Camera.main.ScreenToViewportPoint(Input.mousePosition);
        }
        if (Input.GetMouseButton(0))
        {
            //endPoint = Camera.main.ScreenToViewportPoint(Input.mousePosition);
            //float angle = Mathf.Atan2(startPoint.y - endPoint.y, startPoint.x - endPoint.x)*Mathf.Rad2Deg;
            //base_.transform.localRotation = Quaternion.Euler(0, 0, angle+90);
            //Mathf.Clamp(angle, -80, 80);
            
        }
        //}
        if (Input.GetMouseButtonUp(0))
        {
            GameObject obj_ = Instantiate(ball, point.position, point.rotation);
            obj_.GetComponent<Rigidbody2D>().AddForce(obj_.transform.up * 10f, ForceMode2D.Impulse);
            
        }
        
        
    }
   
}
