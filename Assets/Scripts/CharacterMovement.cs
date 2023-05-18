using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    bool control = false;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (control)
        {
            Vector2 okPoz = transform.position;
            Vector2 mousePoz = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Vector2 direction = mousePoz - okPoz;
            transform.right = -direction * Time.deltaTime;
        }
    }
    private void OnMouseDown()
    {
        control = true;
    }
    private void OnMouseUp()
    {
        control = false;
    }
}
