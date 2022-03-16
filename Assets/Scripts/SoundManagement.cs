using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class SoundManagement : MonoBehaviour
{
	[SerializeField] Image btnSoundOn;
	[SerializeField] Image btnSoundOff;
	private bool muted = false;
    // Start is called before the first frame update
    void Start()
    {
        if(!PlayerPrefs.HasKey("muted")){
        	PlayerPrefs.SetInt("muted", 0);
        }else{
        	Load();
        }
        UpdateButtonIcon();
        AudioListener.pause = muted;
    }

	public void OnButtonPress(){
		if(muted == false){
			muted = true;
			AudioListener.pause = true;
		}else{
			muted = false;
			AudioListener.pause = false;
		}
		Save();
		UpdateButtonIcon();
	}

	private void UpdateButtonIcon(){
		if(muted == false){
			btnSoundOn.enabled = true;
			btnSoundOff.enabled = false;
		}else{
			btnSoundOn.enabled = false;
			btnSoundOff.enabled = true;
		}
	}

	private void Load(){
		muted = PlayerPrefs.GetInt("muted") == 1;
	}

	private void Save(){
		PlayerPrefs.SetInt("muted", muted ? 1 : 0);
	}
    // Update is called once per frame
    void Update()
    {
        
    }
}
