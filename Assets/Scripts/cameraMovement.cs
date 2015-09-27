using UnityEngine;
using System.Collections;

public class cameraMovement : MonoBehaviour {

    public float interpVelocity;
    public float minDistance;
    public float followDistance;
    public GameObject target;
    public Vector3 offset;
    Vector3 targetPos;
    float lastVelocity = 40f;
    bool decel = false;
    public float accelScale = 5f;
   
    // Use this for initialization
    void Start () {

        //targetPos = transform.position;

	}
	
	// Update is called once per frame
	void Update () {
        var move = new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), 0);
        
        if ((transform.position - target.transform.position).magnitude > 40 && move.magnitude > 0)
        {
            transform.position += move * 50f * Time.deltaTime;
        }
            
        else if (((transform.position - target.transform.position).magnitude > 0) && move.magnitude == 0)
        {
            var deltaX = (target.transform.position.x - transform.position.x) / lastVelocity;
            var deltaY = (target.transform.position.y - transform.position.y) / lastVelocity ;
            move = new Vector3(deltaX, deltaY, 0);
            transform.position += move;
        }

        else
        {
            transform.position += move * lastVelocity * Time.deltaTime;
        }

        /*
        if (target)
          {
              lastVelocity = 0;
              Vector3 posNoZ = transform.position;
              posNoZ.z = target.transform.position.z;

              Vector3 targetDirection = (target.transform.position - posNoZ);

              // interpVelocity = targetDirection.magnitude * 5f;

              // targetPos = transform.position + (targetDirection.normalized * interpVelocity * Time.deltaTime);


              Debug.Log("targetDirection mag = " + targetDirection.magnitude);

                          var move = new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), 0);
                          if (move.magnitude != 0)
                           {

                                  decel = false;
                                  lastVelocity = targetDirection.magnitude * accelScale;
                                  targetPos = transform.position + (targetDirection.normalized * lastVelocity * Time.deltaTime);
                                  if(accelScale < 7f)
                                      accelScale += 1f;

                          }
                          else
                          {
                              decel = true;
                              lastVelocity = targetDirection.magnitude * accelScale;
                              targetPos = transform.position + (targetDirection.normalized * lastVelocity * Time.deltaTime);
                              accelScale /= 1.09f;
                          }

              transform.position = Vector3.Lerp(transform.position, targetPos + offset, 0.25f);

          }
      */
    }
}
