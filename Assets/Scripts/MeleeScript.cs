using UnityEngine;
using System.Collections;

public class MeleeScript : MonoBehaviour {
	public int TheDamage = 50;
	public float MaxDistance = 1.5f;
	public float distance;
	public Transform TheMace;

	
	// Update is called once per frame
	private void Update () {
		if (Input.GetButtonDown ("Fire1")) {
			TheMace.animation.Play("Attack");

			RaycastHit hit = new RaycastHit();
			if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit)){
				distance = hit.distance;
				if (distance <= MaxDistance){
					hit.transform.SendMessage("ApplyDamage", TheDamage , SendMessageOptions.DontRequireReceiver);
				}
			}
		}
	}
}
