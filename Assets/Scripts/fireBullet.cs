using UnityEngine;
using System.Collections;

public class fireBullet : MonoBehaviour {

	public GameObject bulletPrefab;
    public GameObject character;
	
	// Update is called once per frame
	void Update () {
        if (Input.GetButtonDown ("Fire1")) {
            Transform firePoint = character.transform.Find("firePoint");
            Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
		}
	}

}
