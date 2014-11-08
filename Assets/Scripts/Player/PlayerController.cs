using UnityEngine;
using System.Collections;
/*
	<author> Glynn Taylor
	Handles input to a keypad, recieving the button presses via addText from KeypadButtons
*/
public class PlayerController : MonoBehaviour
{
	//Texture for crosshair to help player see what button they're pressing
	public Texture2D Crosshair;
	
	// Update is called once per frame
	void Update ()
	{
		//Lock cursor on mouse press (left click)
		if (Input.GetMouseButtonDown (0))
			Screen.lockCursor = true;
		//Release mouse on escape
		if (Input.GetKeyDown (KeyCode.Escape))
			Screen.lockCursor = false;
	}
	//Handles drawing of GUI elements (crosshair)
	void OnGUI()
	{
		//Get x and y top left corner of where to draw the crosshair centered on screen
		float xMin = (Screen.width / 2) - (Crosshair.width / 2);
		float yMin = (Screen.height / 2) - (Crosshair.height / 2);
		//Draw crosshair texture at possition
		GUI.DrawTexture(new Rect(xMin, yMin, Crosshair.width, Crosshair.height), Crosshair);
	}
}
