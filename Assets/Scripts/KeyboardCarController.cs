using UnityEngine;
using System.Collections;

public class KeyboardCarController : CarController {

    public KeyboardCarController() : base(new KeyboardCarInputController()) {
    }
}
