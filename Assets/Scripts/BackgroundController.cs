using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundController : MonoBehaviour
{
    private float length;
    private float startPos;
    public GameObject cam;
    public float parallaxEffect;

    private void Start()
    {
        startPos = transform.position.x;
        length = GetComponent<SpriteRenderer>().bounds.size.x;

    }

    private void FixedUpdate()
    {
        float temp = (cam.transform.position.x * (1 - parallaxEffect));
        float distanace = cam.transform.position.x * parallaxEffect;

        transform.position = new Vector3(startPos + distanace, transform.position.y, transform.position.z);

        if(temp>startPos + length)
        {
            startPos += length;
        }
        else if(temp < startPos - length) 
        {
            startPos -= length;
        }
    }

    private void LateUpdate()
    {
        
    }

}
