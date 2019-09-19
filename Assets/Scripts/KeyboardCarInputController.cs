using UnityEngine;
using System.Collections;

public class KeyboardCarInputController : ICarInputController {
    public float MovePower() {
        return Input.GetAxis("Vertical");
    }

    public float SteerDirection() {
        return Input.GetAxis("Horizontal");
    }
}
