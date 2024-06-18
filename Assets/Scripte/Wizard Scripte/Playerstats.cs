using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class Playerstats
{

    public float castTimer = 1f;
    public float movementSpeed = 2.0f;

    public int hp = 100;
    public int maxhp = 70;

    public float mn = 70;
    public float maxmn = 100;
    public int mnreg = 2;

    public float xp = 0;
    public int xpNeeded = 5;
    public int lvl = 1;

    public void LevelUp()
    {
        castTimer -= Time.deltaTime * 0.1f;
        movementSpeed += 0.1f;
        maxhp += 5;

        //HP und Mana Wieder Auffüllen
        hp = maxhp;
        mn = maxmn;
       
        maxmn += 2;
        mnreg += 1;
    }

    public void GainXP(int newxp)
    {
        xp += newxp;
        Debug.Log(xp);
        //für ein lvl up

        if (xp > lvl * 3)
        {
            xp -= lvl *3;
            LevelUp();
        }
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
