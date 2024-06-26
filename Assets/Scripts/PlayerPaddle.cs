using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPaddle : Paddle
{
    private Vector2 _direction;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.W)) {
            _direction = Vector2.up;
        }
        else if (Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.S)) {
            _direction = Vector2.down;
        }
        else {
            _direction = Vector2.zero;
        }
    }

    void FixedUpdate() {
        if (_direction.sqrMagnitude != 0) {
            _ridgidbody.AddForce(_direction * speed);
        }
    }
}
