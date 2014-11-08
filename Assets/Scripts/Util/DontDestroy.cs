using UnityEngine;
using System.Collections;
/*
	<author> Glynn Taylor
	Helper script to set the flag that controls destroying this gameobject on loading a new level to false
*/
public class DontDestroy : MonoBehaviour {
	//On start
	void Awake() {
		//Set flag then remove script
		DontDestroyOnLoad(transform.gameObject);
		Destroy (this);
	}
}
