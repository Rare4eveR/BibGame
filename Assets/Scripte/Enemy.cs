using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 playerPosition = Wizard.player.transform.position;
        Vector3 distanceVector = playerPosition - transform.position;
        distanceVector = distanceVector.normalized;

        transform.position += distanceVector * Time.deltaTime * 2;
    }

    private void OnCollision2DEnter(Collision2D coll)
    {
        if (coll.gameObject.tag == "Player")
        {
           // Wizard.player.hp -= 10;
            Destroy(gameObject);
            return;

        }
            if (coll.gameObject.tag == "Fireball")
            {
                Destroy(coll.gameObject);
                Destroy(gameObject);
                return;
            }

    }


}
