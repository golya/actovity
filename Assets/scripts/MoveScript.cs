using UnityEngine;
using System.Collections;

public class MoveScript : MonoBehaviour {

	void Update () {
		if (Input.touchCount == 1) {
			Touch touch = Input.GetTouch(0);

			float x = -7.5f + 15 * touch.position.x / Screen.width;
			float y = -4.5f + 9 * touch.position.y / Screen.height;

			transform.position = new Vector3(x, y, 0);
		}
	}
}
