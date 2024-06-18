
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
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

        float x = 15.6f * Random.value - 7.8f;
        float y = 8f * Random.value - 4f;
        Instantiate(targetPrefab, new Vector3(x, y, 0), Quaternion.identity);
        GameManager.Instance.score++;
        Wizard player = Wizard.player;
        Playerstats stats = Wizard.stats;
        stats.xpNeeded += stats.xpNeeded;
        stats.GainXP(1);

        Destroy(gameObject);
        

    }


}
