using UnityEngine;
using System.Collections;

public class EnemyLogic : MonoBehaviour {

	public int Health = 100;
	
	// Update is called once per frame
	private void Update () {
		if (Health <= 0)
		{
			Dead();
		}
	}

	private void Dead(){
		Destroy (gameObject);
	}

	public void ApplyDamage(int theDamage){
		Health -= theDamage;
	}
}
