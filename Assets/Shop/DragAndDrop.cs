﻿using UnityEngine;
using System.Collections;
using System;

public class DragAndDrop : MonoBehaviour
{
    public Camera cameraMain;
    public Transform[] original;
    public Transform[] mask;
    public float shift = 0.01f;
    public string respawnTag = "Respawn";

    public static bool isOn;
    private Transform original_tmp;
    private Transform mask_tmp;
    private Vector3 curPos;

    void Start()
    {
        isOn = false;
    }

    public void SetMask(int id)
    {
        foreach (Transform obj in original)
        {
            string name = obj.name.Split(new char[] { '_' }, StringSplitOptions.RemoveEmptyEntries)[0];
            if (id.ToString() == name)
            {
                original_tmp = Instantiate(obj);
                original_tmp.gameObject.SetActive(false);
            }
        }

        foreach (Transform obj in mask)
        {
            string name = obj.name.Split(new char[] { '_' }, StringSplitOptions.RemoveEmptyEntries)[0];
            if (id.ToString() == name)
            {
                mask_tmp = Instantiate(obj);
            }
        }
    }

    void Update()
    {
        RaycastHit hit;
        Ray ray = cameraMain.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(ray, out hit))
        {
            curPos = hit.point + hit.normal * shift;
        }

        if (mask_tmp)
        {
            mask_tmp.position = curPos;

            if (Input.GetAxis("Mouse ScrollWheel") > 0)
            {
                mask_tmp.localEulerAngles += new Vector3(0, 45, 0);
            }
            if (Input.GetAxis("Mouse ScrollWheel") < 0)
            {
                mask_tmp.localEulerAngles -= new Vector3(0, 45, 0);
            }

            if (Input.GetMouseButtonDown(0) && isOn)
            {
                original_tmp.gameObject.SetActive(true);
                original_tmp.position = mask_tmp.position;
                original_tmp.localEulerAngles = mask_tmp.localEulerAngles;
                original_tmp = null;
                isOn = false;
                Destroy(mask_tmp.gameObject);
            }
            else if (Input.GetMouseButtonDown(1))
            {
                Destroy(original_tmp.gameObject);
                Destroy(mask_tmp.gameObject);
            }
        }
    }
}
