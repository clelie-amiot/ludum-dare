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
        merchant = GameObject.Find("Merchant");
        bubble = GameObject.Find("MerchantBubble");
    }

    // Update is called once per frame
    void Update()
    {
        player = GameObject.Find("CharacterRobotBoy");

        float distance = Vector3.Distance(player.transform.position, merchant.transform.position);
        bubble.SetActive(distance < minDistance);
    }
}
