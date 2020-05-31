using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scrAnimateCircle : MonoBehaviour
{
    [Tooltip("Put the object that is animated into this slot")]
    public Animator localAnimator;

    [HideInInspector]
    public bool isTouched;

    private void Update()
    {
        //Any code could be ran here, not just this animation that happens to be identical to the other scripts. In a game or app, this could play sounds, 
        //completely differnet animations etc...
        if (isTouched == true)
        {
            //Animate
            localAnimator.SetBool("isTouched", true);

            isTouched = false;
        }
        else if (isTouched == false)
        {
            //Ënd animation
            localAnimator.SetBool("isTouched", false);
        }
    }
}
