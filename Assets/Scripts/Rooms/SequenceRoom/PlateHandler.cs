using UnityEngine;
using System.Collections;
/*
	<author> Glynn Taylor
	Handles checking if all pillars are up and if so prevents them moving and displays code text
*/
public class PlateHandler : MonoBehaviour
{
		//Array of all pillars
		public PlateBlock[] Blocks;

		//Checks if all pillars are up 
		public void CheckPlates ()
		{
				//Loop through all pillars
				for (int i=0; i<Blocks.Length; i++) {
					//If one not up then return from method
					if(Blocks[i].Status!=true)
						return;
				}
				//If all blocks are up then set text renderer text and notify blocks that no longer toggleable
				GetComponent<TextMesh>().text="731";
				for (int i=0; i<Blocks.Length; i++) {
					Blocks[i].Finished=true;
				}
				
		}
}
