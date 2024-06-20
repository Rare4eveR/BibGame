using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pausemenü : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GameManager.Instance.pause = gameObject;
        gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnClickContinue()
    {
        gameObject.SetActive(false);
    }

    public void OnClickToTitle()
    {
        GameManager.Instance.ReturnToTitle();
    }

}
