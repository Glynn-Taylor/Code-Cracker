using UnityEngine;
using System.Collections;
/*
	<author> Glynn Taylor
	Handles input to a keypad, recieving the button presses via addText from KeypadButtons
*/
public class KeypadHandler : MonoBehaviour
{
		//The actual door gameobject
		public GameObject Door;
		//Component representing the rendered text
		public TextMesh enteredText;
		//The doors code necessary to make the door open
		public string Code;
		//Text to render
		private string DisplayedText;
		//Whether or not the door is already open
		private bool OpenedDoor = false;
		//How much the door has dissolved when opening
		private float dissolved = 0;

		//On recieving a button press. <param name="text">text on the button e.g. "1"</param>
		public void addText (string text)
		{
				if (!OpenedDoor) {
						//Update text with new number
						DisplayedText += text;
						if (DisplayedText.Length < 3) {
								SoundManager.Instance.Play ("Sounds/Blip_Select");
						//If have gone over char limit (3)
						} else if (DisplayedText.Length > 3) {
								//Reset text to just the new number
								DisplayedText = text;
								SoundManager.Instance.Play ("Sounds/Blip_Select");
						} else {
								if (DisplayedText == Code) {
										SoundManager.Instance.Play ("Sounds/Keypad_Accept");
										//Open the door and make the door non collideable
										OpenedDoor = true;
										Door.collider.enabled = false;
										
								} else {
										SoundManager.Instance.Play ("Sounds/Keypad_Denied");
								}
						}
						//Update the rendered text
						enteredText.text = DisplayedText;
				}
		}
		//Tween the door (if open) until is dissolved (shader effect) 
		void FixedUpdate ()
		{
				if (OpenedDoor && dissolved <= 1.5) {
						//Set shader variable for dissolve
						Door.renderer.material.SetFloat ("_SliceAmount", dissolved);
						//Increase dissolved amount by time passed
						dissolved += Time.deltaTime;
				}
		}
}
