using UnityEngine;
using System.Collections;

public class GroundCheck : MonoBehaviour {

	public bool onGround;
	public LayerMask layM;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {

		onGround = false;

		if(Physics2D.Raycast (new Vector2(transform.position.x, transform.position.y) + new Vector2(0.5f, 0), -Vector2.up, transform.localScale.y))
		{
			onGround = true;
		}
		if(Physics2D.Raycast (new Vector2(transform.position.x, transform.position.y) + new Vector2(-0.5f, 0), -Vector2.up, transform.localScale.y))
		{
			onGround = true;
		}
		if(Physics2D.Raycast (new Vector2(transform.position.x, transform.position.y), -Vector2.up, transform.localScale.y, layM))
		{
			onGround = true;
		}

	}
}
