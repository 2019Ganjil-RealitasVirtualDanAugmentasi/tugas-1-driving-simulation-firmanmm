using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarController : MonoBehaviour
{
    protected ICarInputController controller;
    [SerializeField] private float accelerationSpeed;
    [SerializeField] private float maxSpeed;
    [SerializeField] private float maxRotation;
    private Rigidbody rigidbody;

    private void Awake(){
        if(controller == null)
        {
            Debug.LogError("Input controller is not set");
        }
        rigidbody = GetComponent<Rigidbody>();
    }

    void Update(){
        var acceleration = controller.MovePower();
        if(acceleration != 0) {
            Accelerate(acceleration);
        }
        var rotation = controller.SteerDirection();
        if(rotation != 0) {
            Steer(rotation);
        }
    }

    public void Accelerate(float power){
        var magnitude = rigidbody.velocity.sqrMagnitude;
        if(magnitude < maxSpeed) {
            var direction = transform.forward * power;
            rigidbody.AddForce(direction * accelerationSpeed * Time.deltaTime);
        }
    } 

    public void Steer(float direction) {
        var magnitude = rigidbody.velocity.sqrMagnitude;
        var factor = direction * magnitude / maxSpeed * Time.deltaTime;
        var rotation = transform.rotation.eulerAngles;
        transform.rotation = Quaternion.Euler(rotation.x, rotation.y + factor * maxRotation, rotation.z);
    }

    
}
