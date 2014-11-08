using UnityEngine;
using System.Collections;
/*
	<author> Glynn Taylor
	Teleports the player when walking into this trigger
*/
public class MoveTrigger : MonoBehaviour
{
		//x,y,z to offset the player by
		public int x, y, z;

		// Called on player entering collider
		void OnTriggerEnter (Collider other)
		{
				//Teleport the player by offsetting position
				other.transform.position += new Vector3 (x, y, z);
		}
}
