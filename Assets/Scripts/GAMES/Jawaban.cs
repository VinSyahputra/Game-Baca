using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Jawaban : MonoBehaviour
{
	public GameObject feed_benar, feed_salah;
	private int skor;
    // Start is called before the first frame update
    void Start()
    {
    }

    public void jawaban(bool jawab){
    	if(jawab){
			
    		feed_benar.SetActive (false);
    		feed_benar.SetActive(true);
			if(PlayerPrefs.GetInt("timer") >=24){
				skor = PlayerPrefs.GetInt("skor") + 100;
			}
			else if(PlayerPrefs.GetInt("timer") >=14){
				skor = PlayerPrefs.GetInt("skor") + 50;
			}
			else if(PlayerPrefs.GetInt("timer") >=1){
				skor = PlayerPrefs.GetInt("skor") + 10;
			}
    		
    		PlayerPrefs.SetInt("skor", skor);
			
    	}else{
    		feed_salah.SetActive(false);
    		feed_salah.SetActive(true);
    	}
		// Debug.Log(PlayerPrefs.GetInt("timer"));
		PlayerPrefs.SetInt("timer", 30);
    	gameObject.SetActive(false);
    	transform.parent.GetChild(gameObject.transform.GetSiblingIndex() + 1).gameObject.SetActive(true);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
