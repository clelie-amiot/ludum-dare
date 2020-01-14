using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class healthbar : MonoBehaviour
{
    public GameObject healthbarPrefab;
    private Scrollbar scrollb;
    // Start is called before the first frame update
    void Start()
    {
        scrollb = healthbarPrefab.GetComponent<Scrollbar>();
    }

    void ApplyDamages()
    {
        scrollb.size -= 0.1f;
    }
}
