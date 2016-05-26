using UnityEngine;
using System.Collections;

public class SnapToGrid : MonoBehaviour {

	public int gridSize;

	void Update () {
		transform.position = new Vector3 (Mathf.Floor(transform.position.x / gridSize) * gridSize, 
			Mathf.Floor(transform.position.y / gridSize) * gridSize, transform.position.z);
	}
}
