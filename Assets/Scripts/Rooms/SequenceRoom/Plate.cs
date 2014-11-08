using UnityEngine;
using System.Collections;
/*
	<author> Glynn Taylor
	Handles toggling certain pillars up/down when walking over the plate, plus checking if all pillars are up
*/
public class Plate : MonoBehaviour {
	//Pillars that this block toggles up/down
	public PlateBlock[] Blocks;
	
	//On player entering collider bounds
	void OnTriggerEnter(){
		//Toggle all tracked pillars (if up go down etc.)
		for (int i=0; i<Blocks.Length; i++) {
			Blocks[i].Toggle();
		}
		//Check if all up
		Blocks[0].sendCheck();
		//Play blip sound
		SoundManager.Instance.Play ("Sounds/Blip_Random");
	}
}
