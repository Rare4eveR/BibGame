
using UnityEngine;
using UnityEngine.UIElements;

public class Target : MonoBehaviour
{

    public GameObject targetPrefab;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnCollisionEnter2D(Collision2D collision2D)
    {
        Fireball f = collision2D.gameObject.GetComponent<Fireball>();
        if (tag == "Fireball")
        {
   
        float x = Random.Range(-9, 9);
        float y = Random.Range(-5, 5);

        Instantiate(targetPrefab, new Vector3(x, y, 0), Quaternion.identity);
        Destroy(gameObject);
        }


    }
}