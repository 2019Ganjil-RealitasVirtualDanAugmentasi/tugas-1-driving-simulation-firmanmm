using UnityEngine;
using System.Collections;

public class XboxCarInputController : ICarInputController {
    public float MovePower() {
        return Input.GetAxis("XboxVertical");
    }

    public float SteerDirection() {
        return Input.GetAxis("XboxHorizontal");
    }
}
