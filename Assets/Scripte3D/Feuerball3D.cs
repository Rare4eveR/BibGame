using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Feuerball3D : MonoBehaviour
{

    public Vector3 direction;
    Vector3 lastDirection;
    GameObject Feuerball;

    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, 3);


        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += direction * Time.deltaTime * 4;
        obj.GetComponent<Feuerball3D>();


    }
}
