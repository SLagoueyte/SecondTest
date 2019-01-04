using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2D : MonoBehaviour {

    Rigidbody2D rigidbody;
    Vector2 velocity;

	void Start () {
        rigidbody = GetComponent<Rigidbody2D>();
	}
	
	void Update () {
        velocity = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxisRaw("Vertical")).normalized * 10;	
	}

    private void FixedUpdate() {
        rigidbody.MovePosition(rigidbody.position + velocity * Time.fixedDeltaTime);
    }
}
