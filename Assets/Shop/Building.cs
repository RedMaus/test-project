using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[System.Serializable]
public class Building : ScriptableObject {
    public int Id = 0;
    public string ObjectName = "Введите имя";
    public float[] Size =new float[2];
    public string Description = "Описание";
    public float posX = 0, posY = 0;
}
