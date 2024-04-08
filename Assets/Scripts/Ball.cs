using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    Rigidbody2D _ridgidbody;
    [SerializeField] float speed = 150;

    void Awake() {
        _ridgidbody = GetComponent<Rigidbody2D>();
    }

    // Start is called before the first frame update
    void Start()
    {
        ResetPosition();
        AddStartingForce();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ResetPosition() {
        _ridgidbody.position = Vector3.zero;
        _ridgidbody.velocity = Vector2.zero;
    }

    public void AddStartingForce() {
        float x = Random.value < 0.5f ? -1f : 1f;
        float y = Random.value < 0.5 ? Random.Range(-1f, -0.5f) : Random.Range(0.5f, 1f);
        Vector2 direction = new Vector2(x, y);
        _ridgidbody.AddForce(direction * speed);
    }

    public void AddForce(Vector2 force) {
        _ridgidbody.AddForce(force);
    }
}
