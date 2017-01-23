using UnityEngine;
using System.Collections;

public class CameraBehavior : MonoBehaviour {
	public Camera camera;
	public GameObject player;

	private Vector3 velocity = Vector3.zero;
	public float followValue = 0.15f;

	// Update is called once per frame
	void LateUpdate () {
		var currentCameraPosition = new Vector3 (camera.transform.position.x, camera.transform.position.y, camera.transform.position.z);
		var currentPlayerPosition = new Vector3 (player.transform.position.x, player.transform.position.y, camera.transform.position.z);

		camera.transform.position = Vector3.SmoothDamp(currentCameraPosition, currentPlayerPosition, ref velocity, followValue);
	}
}
