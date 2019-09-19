using UnityEngine;
using System.Collections;

public class KeyboardCarController : CarController {

    public KeyboardCarController() {
        controller = new KeyboardCarInputController();
    }
}
