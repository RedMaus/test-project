using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowMenu : MonoBehaviour {
    public GameObject[] shop;
    private bool St = false;
    public void Show()
    {
        St = !St;
        foreach(GameObject sh in shop)
        {
            sh.SetActive(St);
        }
    }
}
