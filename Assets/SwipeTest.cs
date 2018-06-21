using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SwipeTest : MonoBehaviour
{
    public Swipe swipeControls;

    private void Update()
    {
  
            if (swipeControls.SwipeLeft)
        {
            Singleton.mySingleton.culturalValue = Singleton.mySingleton.culturalValue + Singleton.mySingleton.selectedBill.valueChangeCulturalOnNo;
            Singleton.mySingleton.economyValue = Singleton.mySingleton.economyValue + Singleton.mySingleton.selectedBill.valueChangeEconomyOnNo;
            Singleton.mySingleton.environmentValue = Singleton.mySingleton.environmentValue + Singleton.mySingleton.selectedBill.valueChangeEnvironmentOnNo;
            Singleton.mySingleton.safetyValue = Singleton.mySingleton.safetyValue + Singleton.mySingleton.selectedBill.valueChangeSafetyOnNo;
            Singleton.mySingleton.selectedBill = Singleton.mySingleton.myBills[Random.Range(0, Singleton.mySingleton.myBills.Count)];
            //no
        }
            if (swipeControls.SwipeRight)
        {
            Singleton.mySingleton.culturalValue = Singleton.mySingleton.culturalValue + Singleton.mySingleton.selectedBill.valueChangeCulturalOnYes;
            Singleton.mySingleton.economyValue = Singleton.mySingleton.economyValue + Singleton.mySingleton.selectedBill.valueChangeEconomyOnYes;
            Singleton.mySingleton.environmentValue = Singleton.mySingleton.environmentValue + Singleton.mySingleton.selectedBill.valueChangeEnvironmentOnYes;
            Singleton.mySingleton.safetyValue = Singleton.mySingleton.safetyValue + Singleton.mySingleton.selectedBill.valueChangeSafetyOnYes;
            Singleton.mySingleton.selectedBill = Singleton.mySingleton.myBills[Random.Range(0, Singleton.mySingleton.myBills.Count)];
            //yes
        }
    }
}