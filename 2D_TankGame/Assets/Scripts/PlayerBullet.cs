using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBullet : MonoBehaviour
{


	Rigidbody2D rb;

	private tankEnemy tank_enemy;
	private tankBoss boss;
	private Destroy destroy;

	// Use this for initialization
	void Start()
	{
		rb = GetComponent<Rigidbody2D>();
		tank_enemy = GameObject.FindObjectOfType<tankEnemy>();
		boss = GameObject.FindObjectOfType<tankBoss>();
		destroy = GameObject.FindObjectOfType<Destroy>();
		SoundManagerScript.PlaySound("tank");
		Destroy(gameObject, 3f);
	}

	void OnTriggerEnter2D(Collider2D col)
	{
		if (col.gameObject.name.Equals("tank_enemy"))
		{
			Debug.Log("Hit from player!");
			Destroy(gameObject);
			tank_enemy.enemycurHealth -= 1;
		}
        if (col.gameObject.name.Equals("boss"))
        {
			Debug.Log("Hit from player!");
			Destroy(gameObject);
			boss.bosscurHealth -= 1;
		}
		if (col.gameObject.name.Equals("crateWood"))
		{
			Debug.Log("Hit from player!");
			Destroy(gameObject);
			destroy.boxcurHealth -= 1;
		}
	}
}
