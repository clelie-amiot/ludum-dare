using UnityEngine;
using System.Collections;

public class fireBullet : MonoBehaviour {

	public Transform firePoint;
	public GameObject bulletPrefab;
	public GameObject character;
	
	// Update is called once per frame
	void Update () {
		if (Input.GetButtonDown ("Fire1")) {
			firePoint = character.transform;
			firePoint.position.Set(character.transform.position.x + 0.2f, character.transform.position.y, character.transform.position.z);
			Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
		}
	}

}
