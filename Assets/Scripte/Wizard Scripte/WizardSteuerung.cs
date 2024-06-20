using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.Experimental.AssetDatabaseExperimental.AssetDatabaseCounters;

public class Wizard : MonoBehaviour
{
    public static Wizard player;
    
    public GameObject fireballPrefab;
    
    Vector3 lastMovement = Vector3.zero;

    private Animator animator;

    public static Playerstats stats;

    public float castTimer = 1f;

    public float movementSpeed = 2.0f;


    void Start()
    {
        stats = new Playerstats();

        player = this;

        animator = GetComponent<Animator>();

    }

    // Update is called once per frame
    void Update()
    {

        if (false)
        {
            return;
        }

        //
        // Movement 
        //

        Vector3 movement = Vector3.zero;

        if (Input.GetKey("w"))
        {
            movement += Vector3.up;
            animator.SetBool("Idle", false);
        }
        if (Input.GetKey("s"))
        {
            movement += Vector3.down;
            animator.SetBool("Idle", false);

        }
        if (Input.GetKey("a"))
        {
            movement += Vector3.left;
            animator.SetBool("Idle", false);

        }
        if (Input.GetKey("d"))
        {
            movement += Vector3.right;
            animator.SetBool("Idle", false);

        }

        if (movement.x > 0 || movement.y > 0 || movement.x < 0 || movement.y < 0)
        {
            lastMovement = movement;
            animator.SetBool("Walking", true);
            transform.localScale = new Vector3(1, 1, 1);
        }
        else
        {   
            animator.SetBool("Walking", false);

        }

        if (movement.magnitude > 0)
        {
            GetComponent<SpriteRenderer>().flipX = true;
        }
        if (movement.magnitude < 0)
        {
            GetComponent<SpriteRenderer>().flipX = false;
        }



        float sprintSpeedFactor = 1.0f;
        if (Input.GetKey(KeyCode.LeftShift))
        {
            sprintSpeedFactor = 2.0f;
        }

        transform.position += movement.normalized * Time.deltaTime * movementSpeed * sprintSpeedFactor;

        //
        // Casting
        //

        castTimer -= Time.deltaTime;
        if (Input.GetKeyDown(KeyCode.Space) && castTimer <= 0)
        {
            GameObject obj = Instantiate(fireballPrefab, transform.position, Quaternion.identity);
            obj.GetComponent<Fireball>().direction = lastMovement;
            
            
        }

    }

}

// Probleme: Wizzard Idle animation, Zielscheibe