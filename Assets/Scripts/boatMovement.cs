using UnityEngine;
using System.Collections;

public class boatMovement : MonoBehaviour {

    float speed = 50.0f;

	// Use this for initialization
	void Start () {
      //  transform.position = new Vector3(0, 6, 0);
    }
	
	// Update is called once per frame
	void Update () {

        var move = new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), 0);
        transform.position += move * speed * Time.deltaTime;
    }
}
