using UnityEngine;
using System.Collections;
/*
	<author> Glynn Taylor
	Handles making objects dissapear/reappear in a cycle as you walk round into a trigger
*/
public class LoopShuffle : MonoBehaviour {
	//Objects to cycle through
	public GameObject[] objects;
	//Current index in the cycle
	int index=0;
	
	//Handles player walking into the collider bounds
	void OnTriggerEnter(Collider other){
		//Make all objects invisible/non collideable
		for(int i=0;i<objects.Length;i++){
				objects[i].SetActive(false);
		}
		//Make current index object visible+collideable
		objects[index].SetActive(true);
		//Increment + bounds check index
		index++;
		if(index==objects.Length)
			index=0;
		//Turn this script off in order to prevent player walking back and then forth again, re-enabled by reset script
		enabled=false;
	}
}
