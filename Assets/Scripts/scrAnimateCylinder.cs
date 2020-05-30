using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scrAnimateCylinder : MonoBehaviour
{
    [Tooltip("Put the object that is animated into this slot")]
    public Animator localAnimator;

    [Tooltip("Put the oGame object (or whatever object contains the scrDetectTouchByTag) in this slot")]
    public scrDetectTouchByTag scrDetectTouch;

    private void Update()
    {
        if (scrDetectTouch.touchedCylinder == true)
        {
            //Animate
            localAnimator.SetBool("isTouched", true);
        }
        else if (scrDetectTouch.touchedCylinder == false)
        {
            //Ënd animation
            localAnimator.SetBool("isTouched", false);
        }
    }
}
