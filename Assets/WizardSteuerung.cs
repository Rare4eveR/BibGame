using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class script : MonoBehaviour
{
    public GameObject fireballPrefab;

    public float movementSpeed = 2.0f;
    
    Vector3 lastMovement = Vector3.zero;

    void Start()
    {
        Instantiate(fireballPrefab, transform.position, Quaternion.identity);
    }


    float castTimer = 0f;
   
    void Update()
    {
        float movementSpeed = 2.5f;

        Vector3 movement = Vector3.zero;
        if (Input.GetKey("w"))
        {
            movement += new Vector3(0, 0.02f, 0); //Up
        }

        if (Input.GetKey("a"))
        {
            movement += new Vector3(-0.02f, 0, 0); //Left
        }

        if (Input.GetKey("d"))
        {
            movement += new Vector3(0.02f, 0, 0); //Right
        }

        if (Input.GetKey("s"))
        {
            movement += new Vector3(0, -0.02f, 0); //Down
        }

        if (movement. x > 0 || movement. y > 0 || movement.x < 0 || movement.y < 0)
        { 
        lastMovement = movement;
        }

        //zoom
        if (Input.GetKey("e"))  //zoom
        {
            movement += new Vector3(0, 0, 0.01f);
        }

        if (Input.GetKey("q")) //away
        {
            movement += new Vector3(0, 0, -0.01f);
        }

    
    transform.position += movement.normalized * Time.deltaTime * movementSpeed;

        //Fireball attack

        castTimer -= Time.deltaTime;
        if(Input.GetKeyDown(KeyCode.Space) && castTimer <= 0f) 
        {
            Instantiate(fireballPrefab, transform.position, Quaternion.identity); 
            castTimer = 3;
        }

        if (Input.GetKey("space"))
        {
            Instantiate(fireballPrefab, transform.position, Quaternion.identity);

       
            GameObject obj = Instantiate(fireballPrefab, transform.position, Quaternion.identity);
            obj.GetComponent<fireball>().direction = Vector3.up;
                castTimer = 3;
        }

    }

}     
   
