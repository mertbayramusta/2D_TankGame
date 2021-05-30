using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBullet : MonoBehaviour
{
	float moveSpeed = 7f;

	Rigidbody2D rb;

	private tankMovement tank_green;
	Vector2 moveDirection;

	

	// Use this for initialization
	void Start()
	{
		rb = GetComponent<Rigidbody2D>();
		tank_green = GameObject.FindObjectOfType<tankMovement>();
		moveDirection = (tank_green.transform.position - transform.position).normalized * moveSpeed;
		rb.velocity = new Vector2(moveDirection.x, moveDirection.y);
		SoundManagerScript.PlaySound("enemy");
		Destroy(gameObject, 3f);
	}

	void OnTriggerEnter2D(Collider2D col)
	{
		if (col.gameObject.name.Equals("tank_green"))
		{
			Debug.Log("Hit!");
			Destroy(gameObject);
			tank_green.curHealth -= 1;
		}
	}

}
