using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBoundsX : MonoBehaviour
{
    private float sideBound = -50;
    private float lowerBound = -5;

    // Update is called once per frame
    void Update()
    {
        // Destroy dogs if x position less than left limit
        if (transform.position.x < sideBound)
        {
            Destroy(gameObject);
        } 
        // Destroy balls if y position is less than bottomLimit
        if (transform.position.y < lowerBound)
        {
            Destroy(gameObject);
        }

    }
}
