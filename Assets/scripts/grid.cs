using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class grid : MonoBehaviour {
    public int Size;
    public int StartPos;
    public int gridWidth = 10;
    public int gridHeight = 10;
    public float yOffset = 0.5f;
    public GameObject plane;
    protected GameObject[,] _cells;

    void Start()
    {
        _cells = new GameObject[gridWidth, gridHeight];
        for (int z = 0; z < gridHeight; z++)
        {
            for (int x = 0; x < gridWidth; x++)
            {
                
                _cells[z,x]=Instantiate(plane);
                _cells[z, x].transform.parent = this.gameObject.transform;
                _cells[z, x].transform.position = new Vector3(StartPos+z*Size,yOffset,StartPos+x*Size);
                
            }
        }
        
    }

    void Update()
    {
        
    }


}
