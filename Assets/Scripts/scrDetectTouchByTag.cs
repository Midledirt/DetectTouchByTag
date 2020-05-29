using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scrDetectTouchByTag : MonoBehaviour
{
    Vector3 touchPositionWorld;

    //The game object we touch
    public GameObject touchedObject;

    //Edit this touchphase to alter which touchphase is used for the check
    TouchPhase editableTouchphase = TouchPhase.Ended;

    void Update()
    {
        //Check for finger touches, take the first touch (GetTouch(0))and check its status.
        if (Input.touchCount > 0 && Input.GetTouch(0).phase == editableTouchphase)
        {
            //We get the position of the first touch in "world position"...
            touchPositionWorld = Camera.main.ScreenToWorldPoint(Input.GetTouch(0).position);

            //And store it as a vector2!
            Vector2 touchPositionWOrld2D = new Vector2(touchPositionWorld.x, touchPositionWorld.y);

        }

    }

} 

