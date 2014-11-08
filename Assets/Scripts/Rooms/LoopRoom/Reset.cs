using UnityEngine;
using System.Collections;
/*
	<author> Glynn Taylor
	Simple script to re-enable loop shuffler to allow for players to have to be more likely to complete a full loop before shuffling
*/
public class Reset : MonoBehaviour {
	//Loopshuffler script to enable
	public LoopShuffle Shuffler;
	
	//Enable on player entering collider bounds
	void OnTriggerEnter(Collider other){
		Shuffler.enabled=true;
	}
}
