using UnityEngine;
using System.Collections;

public class fireBullet : MonoBehaviour {

	public Transform firePoint;
    public AudioSource shot;
	public GameObject bulletPrefab;
	
	// Update is called once per frame
	void Update () {
		if (Input.GetButtonDown ("Fire1")) {
            Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
            shot.Play();
		}
	}

}
