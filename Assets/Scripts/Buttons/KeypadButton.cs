using UnityEngine;
using System.Collections;
/*
	<author> Glynn Taylor
	Handles mouse click (down) on a keypad button
*/
public class KeypadButton : MonoBehaviour {
	//The keypad handler to add the input number to
	public KeypadHandler KeypadMaster;
	//What number this button has on it
	public string Text;

	//On mouse clicked down
	void OnMouseDown() {
		//Pass the number to the Handler
		KeypadMaster.addText (Text);
	}
}
