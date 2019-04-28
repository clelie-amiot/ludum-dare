using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class onClickBubble : MonoBehaviour
{
    public GameObject merchantUI;
    
    public void openUI()
    {
        merchantUI.SetActive(true);
    }

    public void closeUI()
    {
        merchantUI.SetActive(false);
    }
}
