using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jawab : MonoBehaviour
{
    public GameObject partikel, bubble, feedbenar, feedsalah;
    public bool benar;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void OnMouseUp(){
        partikel.SetActive(true);
        bubble.SetActive(true);

        if(benar){
            feedbenar.SetActive(false);
            feedbenar.SetActive(true);
        }else{
            feedsalah.SetActive(false);
            feedsalah.SetActive(true);
        }

        Destroy(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
