using UnityEngine;
using System.Collections;

public class XboxCarController : CarController {

    public XboxCarController() : base(new XboxCarInputController()){
    }
}
