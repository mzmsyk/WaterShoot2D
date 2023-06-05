using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallLine : MonoBehaviour
{
    public GameObject point;
    public LineRenderer line;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //yansýma için
        //Vector2 direction =Input.mousePosition- Camera.main.ScreenToWorldPoint(Input.mousePosition);

        RaycastHit2D hit;
        hit = Physics2D.Raycast(point.transform.position, point.transform.up, 50000);
        if (Input.GetMouseButtonDown(0))
        {
            line.gameObject.SetActive(true);
            line.SetPosition(0, point.transform.position);
        }
        if (Input.GetMouseButton(0))
        {
            if (hit.collider != null)
            {
                line.SetPosition(0, point.transform.position);
                line.SetPosition(1, hit.point);
                // yansýma özelliði
                //var vecNormal=Vector2.Reflect(hit.point, hit.normal);
                //line.SetPosition(2, vecNormal);
            }
            
        }
        if (Input.GetMouseButtonUp(0))
        {
            line.gameObject.SetActive(false);
        }
        
    }
}
