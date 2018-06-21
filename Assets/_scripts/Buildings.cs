using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Buildings : MonoBehaviour {
    public string buildingName;
    public GameObject buildingObject;

    public Buildings(string name, GameObject bldObject)
    {
        buildingName = name;
        buildingObject = bldObject;

    }

}
