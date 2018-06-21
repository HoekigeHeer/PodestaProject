using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bills{
    public string billName;
    public int valueChangeEconomyOnYes;
    public int valueChangeSafetyOnYes;
    public int valueChangeEnvironmentOnYes;
    public int valueChangeCulturalOnYes;
    public int valueChangeEconomyOnNo;
    public int valueChangeSafetyOnNo;
    public int valueChangeEnvironmentOnNo;
    public int valueChangeCulturalOnNo;
    public bool spawnBuilding;
    public GameObject buildingToSpawn;

    public Bills(string biName, int valueEcoY, int valueSafeY, int valueEnviY, int valueCultY, int valueEcoN, int valueSafeN, int valueEnviN, int valueCultN, bool spawn, GameObject building)
    {
        billName = biName;
        valueChangeEconomyOnYes = valueEcoY;
        valueChangeSafetyOnYes = valueSafeY;
        valueChangeEnvironmentOnYes = valueEnviY;
        valueChangeCulturalOnYes= valueCultY;
        valueChangeEconomyOnNo = valueEcoN;
        valueChangeSafetyOnNo = valueSafeN;
        valueChangeEnvironmentOnNo = valueEnviN;
        valueChangeCulturalOnNo = valueCultN;
        spawnBuilding = spawn;
        buildingToSpawn = building;
    }

}
