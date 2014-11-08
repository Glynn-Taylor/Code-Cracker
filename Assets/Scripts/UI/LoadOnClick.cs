using UnityEngine;
using System.Collections;
/*
	<author> Glynn Taylor
	Handles menu button clicks by loading a specified level
*/
public class LoadOnClick : MonoBehaviour {
	//Index of level to load
	public int level;
	
	// On mouse down over this collider load the level referenced by the index
	void OnMouseDown(){
		Application.LoadLevel(level);
	}
}
