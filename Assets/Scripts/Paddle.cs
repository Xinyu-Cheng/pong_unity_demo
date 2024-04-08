using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour
{
    protected Rigidbody2D _ridgidbody;
    [SerializeField] protected float speed = 10f;

    void Awake() {
        _ridgidbody = GetComponent<Rigidbody2D>();
    }

    public void ResetPosition() {
        _ridgidbody.position = new Vector2(_ridgidbody.position.x, 0);
        _ridgidbody.velocity = Vector2.zero;
    }
}
