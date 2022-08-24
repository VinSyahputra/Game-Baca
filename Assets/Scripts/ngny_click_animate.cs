using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ngny_click_animate : MonoBehaviour
{
    float x,y;
    // Start is called before the first frame update
    void Start()
    {
        x = transform.localScale.x;
        y = transform.localScale.y;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnMouseDown(){
    	
    	GetComponent<AudioSource>().Play();
    	LeanTween.scale(gameObject, new Vector2(x * 1.8f, y * 1.8f), .5f);
    	// transform.localScale = new Vector2(x * 1.2f, y*1.2f);
    }

    void OnMouseUp(){
    	// transform.localScale = new Vector2(x,y);
    	LeanTween.scale(gameObject, new Vector2(x, y), .25f).setDelay(.5f);
    }
}
