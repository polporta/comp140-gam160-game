using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {

	public static int speed = 1;
	public Vector3 direction = Vector3.left;

	void Update () {

		transform.Translate (direction * speed * Time.deltaTime);
	}
}
