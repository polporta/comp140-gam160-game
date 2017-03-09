using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Reset : MonoBehaviour {
	public GameObject player;
	public Scene sceneToLoad;

	void OnTriggerEnter(Collider other){

		if (other.name == "Walls") {
			SceneManager.LoadScene ("sceneToLoad",LoadSceneMode.Single);
	}
}
}
