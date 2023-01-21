using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName ="playerController",menuName ="InputController/playerController")]
public class playerController : InputController
{
    public override bool RetrieveJumpInput()
    {
        return Input.GetKeyDown("w");
    }

    public override float RetrieveMoveInput()
    {
        return Input.GetAxisRaw("Horizontal");
    }

    public override float RetrieveVerticalInput()
    {
        return Input.GetAxisRaw("Vertical");
    }
}
