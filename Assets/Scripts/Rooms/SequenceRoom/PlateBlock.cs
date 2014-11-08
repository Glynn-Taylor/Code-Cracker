using UnityEngine;
using System.Collections;
/*
	<author> Glynn Taylor
	Handles moving a pillar up/down and checking if all pillars are up
*/
public class PlateBlock : MonoBehaviour {
	//Whether or not is up or down
	public bool Status=true;
	//Wether or not all blocks are up
	public bool Finished=false;
	//Track starting position for displacement
	private Vector3 startingPosition;
	//Handler that checks if all blocks are up
	public PlateHandler Handler;
	
	//Sets starting position on initialisation
	void Start () {
		startingPosition=transform.position;
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		//If need to move up (position<up position)
		if(Status&&transform.position.y-startingPosition.y<0.8f){
			transform.position+=new Vector3(0,0.02f,0);
		//If need to move down (position>initial position)
		}else if(!Status&&transform.position.y-startingPosition.y>0){
			transform.position-=new Vector3(0,0.02f,0);
		}
	}
	//If all are not up then toggle up/down status
	public void Toggle(){
		if(!Finished)
			Status=!Status;
	}
	//Check if all are up
	public void sendCheck(){
		Handler.CheckPlates();
	}
}
