using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class DestroyWalls : MonoBehaviour {
	public Text keyText, keyText2;
	public Image arrowUp, arrowDown;
	public Image arrowUp1, arrowDown1;

	void Start(){
		keyText.enabled = false;
		keyText2.enabled = false;
	}

	void Update () {
		wallUI ();
		destroyWall1 ();
		destroyWall2 ();
	
	}
	void wallUI(){
		arrowUp.enabled = false;
		arrowDown.enabled = false;
		arrowUp1.enabled = false;
		arrowDown1.enabled = false;
		RaycastHit keyInfo;
		Transform cam = Camera.main.transform;
		if (Physics.Raycast (cam.position, cam.forward, out keyInfo, 5f)) {
			if (keyInfo.transform.tag == "Wall1") {
				arrowUp.enabled = true;
				arrowDown.enabled = true;
			}
			if (keyInfo.transform.tag == "Wall2") {
				arrowUp1.enabled = true;
				arrowDown1.enabled = true;
			}
		}
	}

	void destroyWall1(){
		RaycastHit keyInfo;
		Transform cam = Camera.main.transform;
		if (Physics.Raycast (cam.position, cam.forward, out keyInfo, 5f)) {
			if (keyInfo.transform.tag == "Wall1") {
				if (Input.GetKeyDown (KeyCode.UpArrow)) {
					keyText.enabled = true;
					keyText.text = "Pressed";
				}

				if (Input.GetKeyDown (KeyCode.DownArrow)) {
					keyText2.enabled = true;
					keyText2.text = "Pressed";
					Destroy (GameObject.FindGameObjectWithTag ("Wall1"));

					keyText.enabled = false;
					keyText2.enabled = false;
				}
			}
	}
  }

	void destroyWall2(){
		RaycastHit keyInfo;
		Transform cam = Camera.main.transform;
		if (Physics.Raycast (cam.position, cam.forward, out keyInfo, 5f)) {
			if (keyInfo.transform.tag == "Wall2") {
				if (Input.GetKeyDown (KeyCode.DownArrow)) {
					keyText.enabled = true;
					keyText.text = "Pressed";
				}

				if (Input.GetKeyDown (KeyCode.UpArrow)) {
					keyText2.enabled = true;
					keyText2.text = "Pressed";
					Destroy (GameObject.FindGameObjectWithTag ("Wall2"));

					keyText.enabled = false;
					keyText2.enabled = false;
				}
			}
		}
	}
}