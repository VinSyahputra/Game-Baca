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
			// jika jawaban salah
    		feed_salah.SetActive(false);
    		feed_salah.SetActive(true);
			PlayerPrefs.SetInt("hp", PlayerPrefs.GetInt("hp") - 1);
			if(PlayerPrefs.GetInt("hp") == 0){
				transform.parent.GetChild(transform.parent.childCount - 1 ).gameObject.SetActive(true);
			}
    	}
		// Debug.Log(PlayerPrefs.GetInt("timer"));
		PlayerPrefs.SetInt("timer", 30);
    	gameObject.SetActive(false);
    	transform.parent.GetChild(gameObject.transform.GetSiblingIndex() + 1).gameObject.SetActive(true);
    }
    // Update is called once per frame
    void Update()
    {
		// jika waktu habis
        if(PlayerPrefs.GetInt("timerActive") == 0){
			
			feed_salah.SetActive(false);
    		feed_salah.SetActive(true);
			
    		gameObject.SetActive(false);
			// Debug.Log(transform.parent.childCount - 1);
			PlayerPrefs.SetInt("hp", PlayerPrefs.GetInt("hp") - 1);
			if(PlayerPrefs.GetInt("hp") == 0){
				transform.parent.GetChild(transform.parent.childCount - 1 ).gameObject.SetActive(true);
			}else{
			transform.parent.GetChild(gameObject.transform.GetSiblingIndex() + 1).gameObject.SetActive(true);
			PlayerPrefs.SetInt("timer", 30);
			PlayerPrefs.SetInt("timerActive",1);
			}
			
		}
    }
}
