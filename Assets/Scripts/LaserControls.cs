using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserControls : MonoBehaviour
{
    private int laserSpeed = 5;

    void Start()
    {
        
    }

   
    void Update()
    {
        transform.Translate(Vector3.up * Time.deltaTime * laserSpeed);

        if (transform.position.y >= 5.7)
        {
            Destroy(this.gameObject, 1);
        }
    }
}
