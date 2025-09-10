using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerPadlle : Paddle
{
    private Vector2 _direction;

    private void Update()
    {
        if (Keyboard.current.wKey.isPressed || Keyboard.current.upArrowKey.isPressed)
        {
            _direction = Vector2.up;
        }
        else if (Keyboard.current.sKey.isPressed || Keyboard.current.downArrowKey.isPressed)
        {
            _direction = Vector2.down;
        }
        else
        {
            _direction = Vector2.zero;
        }
    }

    private void FixedUpdate()
    {
        if (_direction.sqrMagnitude != 0)
        {
            rb.AddForce(_direction * speed);
        }
    }
}
