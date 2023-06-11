using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireControllers : MonoBehaviour
{
    public GameObject fire;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag=="ball")
        {
            Destroy(this.gameObject, 0.5f);
            fire.SetActive(true);
        }
    }
}
