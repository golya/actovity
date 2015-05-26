using UnityEngine;
using System.Collections;

public class TouchScript : MonoBehaviour {	
	void Update () {
	}

	void OnGUI() {
		
		foreach (Touch touch in Input.touches) {
			string message = "";
			message += "ID: " + touch.fingerId + "\n";
			message += "Phase: " + touch.phase.ToString() + "\n";
			message += "TapCount: " + touch.tapCount + "\n";
			message += "Position X: " + touch.position.x + "\n";
			message += "Position Y: " + touch.position.y + "\n";
			
			int num = touch.fingerId;
			GUI.Label(new Rect(0 + 130 * num, 0, 150, 100), message);
		}
	}
}
