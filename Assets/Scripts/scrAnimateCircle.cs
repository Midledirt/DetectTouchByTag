using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scrAnimateCircle : MonoBehaviour
{
    public Animator localAnimator;

    [Tooltip("Put the oGame object (or whatever object contains the scrDetectTouchByTag) in this slot")]
    public scrDetectTouchByTag scrDetectTouch;

    private void Update()
    {
        if (scrDetectTouch.touchedCircle == true)
        {
            //Animate
            localAnimator.SetBool("isTouched", true);
        }
        else if (scrDetectTouch.touchedCircle == false)
        {
            //Ënd animation
            localAnimator.SetBool("isTouched", false);
        }
    }
}
