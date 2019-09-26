using UnityEngine;
using System.Collections;

public class WheelCarInputController : ICarInputController {

    private bool isForward = true;
    public float MovePower() {
        var accelerationPower = Input.GetAxis("WheelGas");
        var breakPower = Input.GetAxis("WheelBrake");
        accelerationPower = Mathf.Clamp01(accelerationPower - breakPower);
        if (Input.GetAxis("WheelGearUp") > 0) {
            isForward = true;
        }else if (Input.GetAxis("WheelGearDown") > 0) {
            isForward = false;
            accelerationPower = -accelerationPower;
        }
        return accelerationPower;
    }

    public float SteerDirection() {
        return Input.GetAxis("WheelSteer");
    }
}
