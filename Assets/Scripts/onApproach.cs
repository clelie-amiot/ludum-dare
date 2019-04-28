using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class onApproach : MonoBehaviour
{
    public GameObject merchant;
    public GameObject bubble;
    public GameObject player;

    public float minDistance = 2;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        float distance = Vector3.Distance(player.transform.position, merchant.transform.position);
        bubble.SetActive(distance < minDistance);
    }
}
