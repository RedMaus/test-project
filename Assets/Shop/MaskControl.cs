﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaskControl : MonoBehaviour
{

    public string respawnTag = "Respawn";

    void Start()
    {
        DragAndDrop.isOn = true;
    }

    void OnTriggerStay(Collider coll)
    {
        if (coll.tag != respawnTag)
        {
            DragAndDrop.isOn = false;
        }
    }

    void OnTriggerExit(Collider coll)
    {
        if (coll.tag != respawnTag)
        {
            DragAndDrop.isOn = true;
        }
    }

}
