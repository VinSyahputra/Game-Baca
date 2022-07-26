using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaySound : MonoBehaviour
{
    public List<AudioClip> audioClips;
    public AudioSource audioSource;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnMouseDown(){
    	AudioClip clip = audioClips[PlayerPrefs.GetInt("number")];
        audioSource.clip = clip;
        audioSource.Play();
    }
}
