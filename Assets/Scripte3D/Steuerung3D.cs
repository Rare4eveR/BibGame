using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Steuerung3D : MonoBehaviour
{
    public float movement;
    public float angle = Vector3.Angle(movement, Vector3.forward);
    public float movementSpeed = 2.0f;
    public static GameObject Player;
   
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {


        //
        // Movement 
        //

        Vector3 movement = Vector3.zero;

        if (Input.GetKey("w"))
        {
            movement += Vector3.forward;
           
        }
        if (Input.GetKey("s"))
        {
            movement += Vector3.back;
         

        }
        if (Input.GetKey("a"))
        {
            movement += Vector3.left;
           

        }
        if (Input.GetKey("d"))
        {
            movement += Vector3.right;
          

        }


        float sprintSpeedFactor = 1.0f;
        if (Input.GetKey(KeyCode.LeftShift))
        {
            sprintSpeedFactor = 2.0f;
        }

        transform.position += movement.normalized * Time.deltaTime * movementSpeed * sprintSpeedFactor;

        if(movement.x < 0)
        {
            transform.localRotation = Quaternion.Euler (0, 270, 0);
        }

        //
        // Casting
        //

        /*
        castTimer -= Time.deltaTime;
        if (Input.GetKeyDown(KeyCode.Space) && castTimer <= 0)
        {
            GameObject obj = Instantiate(fireballPrefab, transform.position, Quaternion.identity);
            obj.GetComponent<Fireball>().direction = lastMovement;


        }
        */
    }
}
