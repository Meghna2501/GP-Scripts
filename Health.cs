using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour
{
    private int healthcount = 3;

    [SerializeField] private Text healthtext;
    [SerializeField] private Text gameover;

    void OnTriggerEnter2D(Collider2D coll)
    {
        if(coll.gameObject.CompareTag("Trap"))
        {
            healthcount--;
            healthtext.text = "Health :" + healthcount;
            if(healthcount==0)
            {
                gameover.enabled = true;
            }
        }
    }
}
