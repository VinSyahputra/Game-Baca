using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TigaSukuKata : MonoBehaviour
{
	private Animator animator;
	
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseDown(){ //down
    	animator = GetComponent<Animator>();
    	animator.Play("3SukuKata");
    }
}
