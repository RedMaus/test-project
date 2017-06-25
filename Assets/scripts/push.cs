using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class push : MonoBehaviour {
    public GameObject Grid;
    private bool St=true;
	// Use this for initialization
	void Start () {
		
	}
	public void Show()
    {
        St = !St;
        Grid.SetActive(St);
    }
}
