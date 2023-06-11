using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterController : MonoBehaviour
{
    
    
    
    void Start()
    {
        StartCoroutine(DestroyBall());
    }

    
    void FixedUpdate()
    {
        
        
        
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag=="fire")
        {
            Destroy(this.gameObject);
        }
    }
    IEnumerator DestroyBall()
    {
        yield return new WaitForSeconds(3f);
        Destroy(this.gameObject);
    }
}
