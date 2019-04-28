using UnityEngine;
using System.Collections;

public class bullet : MonoBehaviour {

	public float speed = 100f;
	public Rigidbody2D rb;

    // Use this for initialization
    void Start () {
		rb.velocity = rb.transform.right * speed * Time.deltaTime;
	}

	void OnTriggerEnter2D(Collider2D hitInfo) {
		Debug.Log (hitInfo.name);
		Destroy (gameObject);
	}

}
