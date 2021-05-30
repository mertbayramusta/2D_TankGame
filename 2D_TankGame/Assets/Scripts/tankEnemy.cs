using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tankEnemy : MonoBehaviour
{
	[SerializeField]
	GameObject enemy_bullet;

	float fireRate;
	float nextFire;

	//Enemy Health
	public int enemycurHealth;
	public int maxHealth = 3;


	// Use this for initialization
	void Start()
	{
		fireRate = 5f;
		nextFire = Time.time;
		enemycurHealth = maxHealth;
	}

	// Update is called once per frame
	void Update()
	{
		CheckIfTimeToFire();

		// Die Operations
		if (enemycurHealth > maxHealth)
		{
			enemycurHealth = maxHealth;
		}

		if (enemycurHealth <= 0)
		{
			Die();
		}
	}

	void CheckIfTimeToFire()
	{
		if (Time.time > nextFire)
		{
			Instantiate(enemy_bullet, transform.position, Quaternion.identity);
			nextFire = Time.time + fireRate;
		}

	}
	void Die()
	{
		Destroy(gameObject);

	}
}
