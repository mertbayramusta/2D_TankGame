using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tankBoss : MonoBehaviour
{
	[SerializeField]
	GameObject boss_bullet;

	float fireRate;
	float nextFire;

	//Boss Health
	public int bosscurHealth;
	public int maxHealth = 10;

	// For Game Over Screen
	public GameOverScreen gameOverScreen;

	// Use this for initialization
	void Start()
	{
		fireRate = 5f;
		nextFire = Time.time;
		bosscurHealth = maxHealth;
	}

	// Update is called once per frame
	void Update()
	{
		CheckIfTimeToFire();

		// Die Operations
		if (bosscurHealth > maxHealth)
		{
			bosscurHealth = maxHealth;
		}

		if (bosscurHealth <= 0)
		{
			Die();
		}
	}

	void CheckIfTimeToFire()
	{
		if (Time.time > nextFire)
		{
			Instantiate(boss_bullet, transform.position, Quaternion.identity);
			nextFire = Time.time + fireRate;
		}

	}
	void Die()
	{
		Destroy(gameObject);
		gameOverScreen.Setup();
	}
}
