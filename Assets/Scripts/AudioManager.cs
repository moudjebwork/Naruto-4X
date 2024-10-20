using Unity.Collections;
using UnityEngine;
using System;

public class AudioManager : MonoBehaviour
{

    public static AudioManager instance;

    public Sound[] musicSounds, sfxSounds;
    public AudioSource musicSource, sfxSource;

    private void Awake()
    {
        if(instance == null){
            instance = this;
            DontDestroyOnLoad(instance);
        }
        else{
            Destroy(gameObject);
        }
    }

    private void Start(){
        PlayMusic("Theme");
    }

    public void PlayMusic(string name)
    {
        Sound s = Array.Find(musicSounds, x => x.name == name);  

        if (s == null)
        {
            Debug.Log("Music called but not found !");
        } 
        else
        {
            musicSource.clip = s.clip;
            musicSource.Play();
        } 
    }

    public void PlaySFX(string name)
    {
        Sound s = Array.Find(sfxSounds, x => x.name == name);  

        if (s == null)
        {
            Debug.Log("SFX called but not found !");
        } 
        else
        {
            sfxSource.PlayOneShot(s.clip);
        } 
    }


}
