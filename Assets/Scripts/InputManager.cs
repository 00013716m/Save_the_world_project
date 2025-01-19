using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class InputManager : MonoBehaviour
{
    private PlayerInput playerInput;
    private PlayerInput.WalkActions walk;

    private PlayerMotor motor;
    // Start is called before the first frame update
    void Awake()
    {
        playerInput = new PlayerInput();
        walk = playerInput.Walk;
        motor = GetComponent<PlayerMotor>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        motor.ProcessMove(walk.Movement.ReadValue<Vector2>());
    }
    private void OnEnable()
    {
        walk.Enable();
    }
    private void OnDisable()
    {
        walk.Disable();
    }
}
