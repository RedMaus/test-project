using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trees : MonoBehaviour {
    public int width, height;
    public float mapSize;
    public GameObject tree;    
    void Start () {
        for (int j = 0; j < Random.Range(5,15); j++)
        {
            int treeCount = Random.Range(120, 200);
            for (int i = 0; i < treeCount; i++)
            {
                Vector3 spawn = Random.insideUnitCircle.normalized * (mapSize+j*15);
                spawn.z = spawn.y;
                spawn.y = 0;
                tree.transform.position = spawn;
                Instantiate(tree);
            }
        }
    }
    // Update is called once per frame
    void Update () {
		
	}
}
