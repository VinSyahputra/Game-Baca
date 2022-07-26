using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataSoal : MonoBehaviour
{
    public GameObject hasil_bermain;
    int urutan = 0;
    // Start is called before the first frame update
    void Start()
    {
        set_ufo();
    }

    public void control(int i){
        if(urutan < transform.childCount){
            
            urutan+=i;
        }
        
        set_ufo();
    }

    public void set_ufo(){
        for (int i = 0; i < transform.childCount; i++)
        {
            transform.GetChild(i).gameObject.SetActive(false);
        }
        if(urutan < transform.childCount){

            transform.GetChild(urutan).gameObject.SetActive(true);
        }else{
            transform.GetChild(urutan-1).gameObject.SetActive(false);
            hasil_bermain.SetActive(true);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
