using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;
using UnityEngine.UIElements;

public class fireball : MonoBehaviour
{


    void Start()
    {

        transform.Rotate(new Vector3(0, 0, Angle));
        float angle Vector3.Angle (direction, Vector3.right);

        if (Direction.y >= 0)
        {
            transform.Rotate(new Vector3(0, 0, angle));
        }
        if (Direction.y < 0)
        {
            transform.Rotate(new Vector3(0, 0, angle + 180));
        }

        if (direction.y > 0)
        {
            transform.Rotate(new Vector3(0, 0, 90));
        }
        if (direction.y < 0)
        {
            transform.Rotate(new Vector3(0, 0, 270));
        }
        if (direction.x < 0)
        {
            transform.Rotate(new Vector3(0, 0, 180));
        }


        Destroy(gameObject, 3);
        
    }

    void Update()
    {

        transform.position = transform.position + direction *4 * Time.deltaTime;

    }
}
