using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour
{

    private float screenCenterX;
    private float  speed=1f;

    private void Start()
    {
        // save the horizontal center of the screen
        screenCenterX = Screen.width * 0.5f;
    }

    private void Update()
    {
        // if there are any touches currently
        if (Input.touchCount > 0)
        {
            // get the first one
            Touch firstTouch = Input.GetTouch(0);

            // if it began this frame
            if (firstTouch.phase == TouchPhase.Stationary)
            {

                if (firstTouch.position.x > screenCenterX)
                {
                    GetComponent<Rigidbody>().AddForce(Vector3.right * speed, ForceMode.Impulse);
                    //transform.Translate(Vector3.right*Time.deltaTime*10);
                    // if the touch position is to the right of center
                    // move right
                }
                else if (firstTouch.position.x < screenCenterX)
                {
                    GetComponent<Rigidbody>().AddForce(Vector3.left * speed, ForceMode.Impulse);
                    // if the touch position is to the left of center
                    // move left
                }
                if (UiControls.UiButtonTriggred)
                {
                    //UiControls.UiButtonTriggred = false;
                    Debug.Log("Ui triggred");
                }
                else
                {
                    
                    
                }
                UiControls.UiButtonTriggred = false;


            }
        }
    }
    private void OnMouseDown()
    {
        //if (UiControls.jump)
        //{
            
        //    UiControls.jump = false;
        //}
        GetComponent<Rigidbody>().AddForce(Vector3.up * 20, ForceMode.Impulse);
    }
}
