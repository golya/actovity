using UnityEngine;
using System.Collections;
using System.Text;

public class AccelScript : MonoBehaviour {
	void Update () {
		Client cli = GameObject.Find("maincam").GetComponent ("Client") as Client;
		cli.sendMsg(Input.acceleration.x, Input.acceleration.y);
	}

	void Move() {
		
	}
}
