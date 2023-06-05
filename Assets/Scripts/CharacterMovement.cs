using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    [Header("Rotation Character")]
    private Camera myCam;
    private Vector3 screenPos;
    private float angleOffset;
    [Header("Ball Operation")]
    public GameObject ball;
    public Transform point;

    
    private void Start()
    {
        myCam = Camera.main;
    }
    private void Update()
    {
        

        if (Input.GetMouseButtonDown(0))
        {
            screenPos = myCam.WorldToScreenPoint(transform.position);
            Vector3 vec3 = Input.mousePosition - screenPos;
            angleOffset = (Mathf.Atan2(transform.right.y, transform.right.x) - Mathf.Atan2(vec3.y, vec3.x)) * Mathf.Rad2Deg;
        }
        if (Input.GetMouseButton(0))
        {
            Vector3 vec3 = Input.mousePosition - screenPos;
            float angle = Mathf.Atan2(vec3.y, vec3.x) * Mathf.Rad2Deg;
            transform.eulerAngles = new Vector3(0, 0, (angle + angleOffset));
            
        }
        if (Input.GetMouseButtonUp(0))
        {
            GameObject objBall = Instantiate(ball, point.position, point.rotation);
            objBall.GetComponent<Rigidbody2D>().AddForce(objBall.transform.up * 10f, ForceMode2D.Impulse);

        }
        //Mathf.Clamp(transform.rotation.z, -80, 80);
    }































    /*bool control = false;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {

            Vector3 arrowPos = transform.position;
            Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            mousePos.z = 0;
            Vector3 direction = mousePos - arrowPos;
            transform.right = -direction * 2 * Time.deltaTime;


        }
        //if (control)
        //{
        //    //Vector3 arrowPos = transform.position;
        //    //Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        //    //mousePos.z = 0;
        //    //Vector3 direction = mousePos - arrowPos;
        //    //transform.right = -direction * 2 * Time.deltaTime;
        //    float rotation = Input.mousePosition.x * .5f * Time.deltaTime;

        //    // Dönüþü uygula
        //    transform.Rotate(0f, 0f, rotation);

        //    //transform.rotation = Quaternion.Euler(0, 0, -rotation*5).normalized;
        //    // Mathf.Clamp(rotation, -80, 80);
        //}
        //if (Input.touchCount > 0)
        //{
        //    Touch touch = Input.GetTouch(0);

        //    // Dönüþ açýsý hesaplamasý
        //    float rotation = touch.deltaPosition.x * 100f * Time.deltaTime;

        //    // Dönüþü uygula
        //    transform.Rotate(0f, 0f, rotation);
        //}

    }
    private void OnMouseDown()
    {
        control = true;
    }
    private void OnMouseUp()
    {
        control = false;
    }

    /* public float power = 10f;
     public float maxDrag = 5;
     public Rigidbody2D rb;

     Vector3 dragStartPos;
     private void Update()
     {
         if (Input.GetMouseButtonDown(0))
         {
             DragStart();
         }
         if (Input.GetMouseButton(0))
         {
             Dragging();
         }
         if (Input.GetMouseButtonUp(0))
         {
             DragRelease();
         }
     }
     void DragStart()
     {
         dragStartPos = Camera.main.ScreenToViewportPoint(Input.mousePosition);
         dragStartPos.z = 0;


     }
     void Dragging()
     {
         Vector3 draggingPos = Camera.main.ScreenToViewportPoint(Input.mousePosition);
         draggingPos.z = 0;

     }
     void DragRelease() 
     {
         Vector3 dragReleasePos = Camera.main.ScreenToViewportPoint(Input.mousePosition);
         dragReleasePos.z = 0;
         Vector3 force = dragStartPos - dragReleasePos;
         Vector3 clampedForce = Vector3.ClampMagnitude(force, maxDrag) * power;
         rb.AddForce(clampedForce, ForceMode2D.Impulse);
     }*/
}
