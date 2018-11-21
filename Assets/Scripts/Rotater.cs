using UnityEngine;

public class Rotater : MonoBehaviour {

	void Update () {
        transform.Rotate(15 * Time.deltaTime, 30 * Time.deltaTime, 45 * Time.deltaTime);
	}
}
