using UnityEngine;
using System.Collections;

public class WheelCarController : CarController {

   public WheelCarController() : base(new WheelCarInputController()){
    }
}
