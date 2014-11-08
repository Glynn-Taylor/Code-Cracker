using UnityEngine;
using System.Collections;
using System.Collections.Generic;

/*
	<author> Glynn Taylor
	Handles dynamic loading and playing of sounds when only one sound can be played at any one time
*/
public class SoundManager  : MonoBehaviour {
	//Singleton instance
	private static SoundManager instance;
	//Cache for loaded clips
	private Dictionary<string,AudioClip> LoadedSounds = new Dictionary<string,AudioClip> ();
	
	//Plays a clip with just a filename
	public void Play(string filename){
		//Check if sound is cached
		if(LoadedSounds.ContainsKey(filename)){
			audio.clip=LoadedSounds[filename];
		}else{
			try{
				//Load sound
				LoadedSounds.Add (filename,Resources.Load (filename) as AudioClip);
				audio.clip=LoadedSounds[filename];
			}catch{
				
			}
		}
		//Play set clip
		audio.Play();
	}
	public void Play(string path,string filename){
		//Check if sound is cached
		if(LoadedSounds.ContainsKey(filename)){
			audio.clip=LoadedSounds[filename];
		}else{
			try{
				//Load sound
				LoadedSounds.Add (filename,Resources.Load (path +"/"+filename) as AudioClip);
				audio.clip=LoadedSounds[filename];
			}catch{
				
			}
		}
		//Play set clip
		audio.Play();
	}
	//Getter for singleton, handles singleton creation if non existant
	public static SoundManager Instance
	{
		get
		{
			//Create if not existant
			if (instance == null)
			{
				instance = new GameObject ("SoundManager").AddComponent<SoundManager> ();
				//Add audio source component to play the sound
				instance.gameObject.AddComponent<AudioSource>();
			}
			return instance;
		}
	}
 	//Removal of pointer for garbage collection on quit
	public void OnApplicationQuit ()
	{
		instance = null;
	}
	
}
