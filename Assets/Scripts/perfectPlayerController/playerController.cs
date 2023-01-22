using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName ="playerController",menuName ="InputController/playerController")]
public class playerController : InputController
{
   //for PC
    /*public override bool RetrieveJumpInput()
    {
        return Input.GetKeyDown("w");
    }

    public override float RetrieveMoveInput()
    {
        return Input.GetAxisRaw("Horizontal");
    }*/

    //for mobile
    public override bool RetrieveJumpInput()
    {
        return Input.touches[0].phase == TouchPhase.Began;
    }

    public override float RetrieveMoveInput()
    {
        return Input.acceleration.x >0 ? 1: -1;
    }

    public override float RetrieveVerticalInput()
    {
        return Input.GetAxisRaw("Vertical");
    }
}

