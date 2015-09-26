using UnityEngine;
using System.Collections;

public class cameraMovement : MonoBehaviour {

    public float interpVelocity;
    public float minDistance;
    public float followDistance;
    public GameObject target;
    public Vector3 offset;
    Vector3 targetPos;
    public float lastVelocity;
    bool decel = false;
    public float accelScale = 5f;
   
    // Use this for initialization
    void Start () {

        targetPos = transform.position;

	}
	
	// Update is called once per frame
	void Update () {
        if (target)
        {
            Vector3 posNoZ = transform.position;
            posNoZ.z = target.transform.position.z;

            Vector3 targetDirection = (target.transform.position - posNoZ);

            interpVelocity = targetDirection.magnitude * 5f;

            targetPos = transform.position + (targetDirection.normalized * interpVelocity * Time.deltaTime);

            transform.position = Vector3.Lerp(transform.position, targetPos + offset, 0.25f);

            /*
                        var move = new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), 0);
                        if (move.magnitude != 0)
                         {

                                decel = false;
                                lastVelocity = targetDirection.magnitude * accelScale;
                                targetPos = transform.position + (targetDirection.normalized * lastVelocity * Time.deltaTime);
                                if(accelScale < 5f)
                                    accelScale += 1f;

                        }
                        else
                        {
                            decel = true;
                            lastVelocity = targetDirection.magnitude * accelScale;
                            targetPos = transform.position + (targetDirection.normalized * lastVelocity * Time.deltaTime);
                            accelScale /= 1.09f;
                        }
                        */
        }
	
	}
}
