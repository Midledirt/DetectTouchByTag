using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scrDetectTouchByTag : MonoBehaviour
{
    Vector3 touchPositionWorld;

    //Touched object
    private GameObject touchedObject;

    //Edit this touchphase to alter which touchphase is used for the check
    TouchPhase editableTouchphase = TouchPhase.Ended;

    [HideInInspector]
    public bool touchedCylinder;
    [HideInInspector]
    public bool touchedSquare;
    [HideInInspector]
    public bool touchedCircle;

    private void Start()
    {
        touchedSquare = false;
        touchedCylinder = false;
        touchedCircle = false;
    }
    void Update()
    {
        //Check for finger touches, take the first touch (GetTouch(0))and check its status.
        if (Input.touchCount > 0 && Input.GetTouch(0).phase == editableTouchphase)
        {
            //We get the position of the first touch in "world position"...
            touchPositionWorld = Camera.main.ScreenToWorldPoint(Input.GetTouch(0).position);

            //And store it as a vector2!
            Vector2 touchPositionWOrld2D = new Vector2(touchPositionWorld.x, touchPositionWorld.y);

            //Make a list of colliders whenever colliders are touched
            Collider2D[] colliders = Physics2D.OverlapCircleAll(touchPositionWOrld2D, .1f);

            foreach (var col in colliders)
            {

                //If we hit something, store information of the gameobject into the variable "touchedObject".
                touchedObject = col.gameObject;
                //print(touchedObject.name + " touched");

                //Prints the name of the object touched
                //print("Touched" + touchedObject.transform.name);

                //Make the touched object respond
                if (touchedObject.tag == "Circle")
                {
                    //StartCoroutine(resetTouch());
                    touchedObject.GetComponent<scrAnimateCircle>().isTouched = true;
                    //touchedCircle = true;
                    //print("hit a circle");
                }
                else if (touchedObject.tag == "Square")
                {
                    //StartCoroutine(resetTouch());
                    touchedObject.GetComponent<scrAnimateSquare>().isTouched = true;
                    //touchedSquare = true;
                    //print("hit a square");
                }
                else if (touchedObject.tag == "Cylinder")
                {
                    //touchedCylinder = true;
                    touchedObject.GetComponent<scrAnimateCylinder>().isTouched = true;
                    //StartCoroutine(resetTouch());
                    //print("hit a cylinder");
                }
                else
                {
                    return;
                }

            }

        }

    }

    /*IEnumerator resetTouch()
    {
        //Reset bools to false
        yield return new WaitForSeconds(0.1f);
        touchedCylinder = false;
        touchedCircle = false;
        touchedSquare = false;
    }*/

}


