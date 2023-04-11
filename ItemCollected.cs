using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ItemCollected : MonoBehaviour
{
    private int count = 0;

    [SerializeField] private Text scoretext;

    void OnTriggerEnter2D(Collider2D coll)
    {
        if(coll.gameObject.CompareTag("Collectible"))
        {
            Destroy(coll.gameObject);
            count++;
            print(count);
            scoretext.text = "Score :" + count;
            if(count==3)
            {
                SceneManager.LoadScene("Scene2");
            }
        }
    }
}
