using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Hud : MonoBehaviour
{

    int score = GameManager.Instance.score;
    public TMP_Text hp;
    public TMP_Text mn;
    public TMP_Text scoreText; 
    public TMP_Text lvl;
    public TMP_Text xpRequired;
    public TMP_Text lvlText;

    public Image hpbarimage;
    public Image lvlImage;
    public Image mnbarimage;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = "Score : " + score;
        hp.text = "HP : " + " " + Wizard.stats.hp;
        mn.text = "Mana : " + " " + Wizard.stats.maxmn;
        lvlText.text = "Level: " + " " + Wizard.stats.lvl;


        /* float healthpercentage = (float) w.hp / (float)maxhp;
         hpbarimage.transform.localScale = new Vector3(healthpercentage, 1,1);
        */

        float manaPercentage = Wizard.stats.mn / Wizard.stats.maxmn;
        mn.transform.localScale = new Vector3(manaPercentage, 1, 1);

        float healthPercentage = Wizard.stats.hp / Wizard.stats.maxhp;
        mn.transform.localScale = new Vector3(manaPercentage, 1, 1);

        float xpPercentage = Wizard.stats.lvl / Wizard.stats.xpNeeded;
        mn.transform.localScale = new Vector3(manaPercentage, 1, 1);
    }



}
