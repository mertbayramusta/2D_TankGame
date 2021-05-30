using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour
{
	//Box Health
	public int boxcurHealth;
	public int maxHealth = 1;


	// Use this for initialization
	void Start()
	{
		boxcurHealth = maxHealth;
	}

	// Update is called once per frame
	void Update()
	{
		// Die Operations
		if (boxcurHealth > maxHealth)
		{
			boxcurHealth = maxHealth;
		}

		if (boxcurHealth <= 0)
		{
			Die();
		}
	}
	void Die()
	{
		Destroy(gameObject);

	}
}
