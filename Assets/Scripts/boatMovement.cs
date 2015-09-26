using UnityEngine;
using System.Collections;

public class boatMovement : MonoBehaviour {

    float speed = 10.0f;

	// Use this for initialization
	void Start () {
      //  transform.position = new Vector3(0, 6, 0);
    }
	
	// Update is called once per frame
	void Update () {
        var move = new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), 0);
        //speed = 7.0f;
       /* if (move.magnitude == 0)
        {
            Debug.Log("Hot Dogs");
            speed = 5;
        }*/
      //  if (move.magnitude > 0)
      //  {
           // Debug.Log("I am not here");
            transform.position += move * speed * Time.deltaTime;
       // }

    }
}
