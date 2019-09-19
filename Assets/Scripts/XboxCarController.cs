using UnityEngine;
using System.Collections;

public class XboxCarController : CarController {

    public XboxCarController() {
        controller = new XboxCarInputController();
    }
}
