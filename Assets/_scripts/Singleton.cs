using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Singleton : MonoBehaviour {
    public static Singleton mySingleton;
    public int economyValue;
    public int safetyValue;
    public int environmentValue;
    public int culturalValue;
    public int economyValueMax;
    public int economyValueMin;
    public int safetyValueMax;
    public int safetyValueMin;
    public int environmentValueMax;
    public int environmentValueMin;
    public int culturalValueMax;
    public int culturalValueMin;
    public List<Bills> myBills;
    public Bills selectedBill;
    public GameObject temp;

    private void Awake()
    {
        if (Singleton.mySingleton == null)
        {
            Singleton.mySingleton = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }

        myBills = new List<Bills>();
        economyValueMin = 0;
        economyValueMax = 25;
        safetyValueMin = 0;
        safetyValueMax = 25;
        environmentValueMin = 0;
        environmentValueMax = 25;
        culturalValueMin = 0;
        culturalValueMax = 25;
        economyValue = 13;
        culturalValue = 5;
        environmentValue = 2;
        safetyValue = 9;
        AddBillsToList();
    }
    // Use this for initialization
    void Start () {
    }
	
	// Update is called once per frame
	void Update () {
		if (economyValue < economyValueMin)
        {
            economyValue = economyValueMin;
        }
        if (economyValue > economyValueMax)
        {
            economyValue = economyValueMax;
        }
        if (safetyValue < safetyValueMin)
        {
            safetyValue = safetyValueMin;
        }
        if (safetyValue > safetyValueMax)
        {
            safetyValue = safetyValueMax;
        }
        if (environmentValue < environmentValueMin)
        {
            environmentValue = environmentValueMin;
        }
        if (environmentValue > environmentValueMax)
        {
            environmentValue = environmentValueMax;
        }
        if (culturalValue < culturalValueMin)
        {
            culturalValue = culturalValueMin;
        }
        if (culturalValue > culturalValueMax)
        {
            culturalValue = culturalValueMax;
        }
    }


    public void AddBillsToList()
    {
        myBills.Add(new Bills("test", 1, 2, 3, 4, 3, 2, 1, 2, true, temp));
        myBills.Add(new Bills("Het financieel ondersteunen van een park", -1, 0, 2, 1, 1, 0, -1, 0, true, temp));
        myBills.Add(new Bills("Bouw een school", -1, 0, 0, 1, 1, 0, 0, -1, true, temp));
        myBills.Add(new Bills("Laat een fabriek in de stad bouwen", 2, 0, -2, 0, -1, 0, 1, 0, true, temp));
        myBills.Add(new Bills("Er moet meer blauw op straat komen", -1, 2, 0, 0, 0, -1, 0, 0, true, temp));
        myBills.Add(new Bills("Er moet een nieuwe weg gebouwd worden", 1, 0, -2, 0, 0, 0, 1, 0, true, temp));
        myBills.Add(new Bills("Er komt een weekmarkt in de stad", 2, 0, -1, 1, -1, 0, 1, -1, true, temp));
        myBills.Add(new Bills("Er moet een nieuwe wijk gebouwd worden", -1, -1, -1, 2, 0, 0, 1, -1, true, temp));
        myBills.Add(new Bills("Er moeten nieuwe winkels gebouwd worden", 2, 0, -1, 0, -2, 0, 1, 0, true, temp));
        myBills.Add(new Bills("Er wordt een flat gebouwd voor vluchelingen", -2, -2, -1, +2, 1, 1, 0, -1, true, temp));
        myBills.Add(new Bills("Er wordt een vliegveld gebouwd in de stad", 2, -1, -2, 0, -2, 1, 2, 0, true, temp));
        myBills.Add(new Bills("Politieagenten dreigen te staken tenzij ze een loonsverhoging krijgen", -2, 1, 0, 0, 1, -2, 0, 0, false, temp));
        myBills.Add(new Bills("De lokale concertzaal wil een kostbare voorstelling vertonen, en wil hiervoor financiering krijgen van de gemeente", -1, 0, 0, 2, 1, 0, 0, -2, false, temp));
        myBills.Add(new Bills("Men wil een bowlingbaan om vrije tijd te besteden", 1, 1, -2, 1, 1, -1, 0, -1, true, temp));
        myBills.Add(new Bills("De provincie wil een snelweg laten aanleggen door de stad heen in ruil voor een compensatie", 2, -1, -2, -1, -1, 0, 1, 1, true, temp));
        myBills.Add(new Bills("Er moeten wolkenkrabbers gebouwd worden", 2, -1, -1, 1, -1, 0, 0, 0, true, temp));
        myBills.Add(new Bills("Verkiezingen moeten voortaan digitaal gehouden worden", -1, 1, 0, 0, 1, -1, 0, 0, false, temp));
        myBills.Add(new Bills("Men wil meer bomen in de stad", -1, 0, 2, 0, 1, 0, -1, 0, true, temp));
        myBills.Add(new Bills("Er wordt een concerthal gebouwd op de plaats waar eerst een park stond", 2, -1, -2, 2, -1, 0, 1, -1, true, temp));
        myBills.Add(new Bills("Men wilt cocaine legaliseren", 2, -3, -1, 2, -1, -1, 0, 0, false, temp));
        myBills.Add(new Bills("Dragen van wapens op straat moet legaal worden", 2, -1, -1, 1, -1, 0, 0, 0, false, temp));
        myBills.Add(new Bills("Het zeggen van iets waarmee je iemand beledigd moet strafbaar zijn", 0, 1, 0, -2, 0, 0, 0, 1, false, temp));
        myBills.Add(new Bills("Verbied religie in je stad", 1, 1, 0, -2, -1, 0, 0, 1, false, temp));
        myBills.Add(new Bills("Prositutie legalizeren in je stad", 2, -2, 0, 1, 0, 1, 0, 0, false, temp));
        myBills.Add(new Bills("Men wil een anime conventie regelen in de stad", 1, 0, -1, 1, -1, 0, 1, 0, false, temp));
        myBills.Add(new Bills("Verbied alle autos in je stad", -2, 0, 3, -1, 1, 0, -1, 0, false, temp));
        myBills.Add(new Bills("Men wilt fossiele brandstoffen verbieden", -2, 0, 3, 0, 2, 0, -2, 0, false, temp));
        myBills.Add(new Bills("Iedereen in de stad krijgt hetzelfde inkomen", -2, 0, 0, 0, 1, 0, 0, 0, false, temp));
        myBills.Add(new Bills("Homosexualiteit moet illegaal worden", 0, -1, 0, -1, 0, 1, 0, 1, false, temp));
        myBills.Add(new Bills("De hele stad moet gender neutraal worden", 0, 1, 0, -2, 0, 0, 0, 1, false, temp));
        myBills.Add(new Bills("De doodstraf moet ingevoerd worden", 0, 2, -1, -2, 0, -2, 1, 2, false, temp));
        myBills.Add(new Bills("De minimumleeftijd voor alcohol moet verlaagd worden naar 14", 2, -2, -1, 1, 0, 0, 0, -1, false, temp));
        myBills.Add(new Bills("Het moet illegaal worden om seks te hebben voor het huwelijk", 0, 0, 0, -2, 0, 0, 0, 2, false, temp));
        myBills.Add(new Bills("Boetes voor te hard rijden moeten fors omhoog", 2, 1, 1, -1, 0, -1, 0, 0, false, temp));
        myBills.Add(new Bills("Je bevolking wilt een jaarlijkse purge instellen", -2, 2, -2, 2, 1, -1, 2, -2, false, temp));
        myBills.Add(new Bills("Kunst moet eerst worden goedgekeurd door de staat", -1, 1, 0, -3, 0, 0, 0, 1, false, temp));
        myBills.Add(new Bills("Er wordt een colosseum in de stad gebouwd", 1, 0, 0, 3, -1, 0, 0, -1, true, temp));
        myBills.Add(new Bills("Voer een Anarchy in", 0, -3, 0, -2, 0, 2, 0, 1, false, temp));
        myBills.Add(new Bills("Er is een protest bezig die tot veel overlast lijdt maar niks illegaals doet, houd je dit tegen?", 0, 2, 2, -2, 0, -3, -3, 1, false, temp));
        myBills.Add(new Bills("Er wordt een nieuw industrieterrein aangemaakt in het midden van de stad", 2, 0, -2, 0, -1, 0, 1, 0, true, temp));
        myBills.Add(new Bills("De prijs van tabak moet omhoog", 2, 0, 1, -2, -1, 0, -1, 2, false, temp));
        myBills.Add(new Bills("Gaming moet illegaal worden", -2, -2, 3, -2, 1, 0, 0, 1, false, temp));
        myBills.Add(new Bills("Er moet een muur om de stad heen komen", -1, 2, 0, -1, 1, -1, 0, 0, true, temp));
        myBills.Add(new Bills("Men moet voortaan door een grenscontrole heen om de stad in te komen", 0, 3, 0, -2, 0, -2, 0, 2, false, temp));
        myBills.Add(new Bills("Urineren in het openbaar moet legaal worden", 0, 0, -3, 1, 0, 0, 2, -1, false, temp));
        myBills.Add(new Bills("Een afgebrande school moet herbouwd worden", -2, 1, 0, 2, 1, -1, 0, -3,true, temp));
        myBills.Add(new Bills("Men wil op de plaats van een verlate fabriek een woonwijk bouwen", -1, 0, 1, 2, 1, 0, -1, -1, true, temp));
        myBills.Add(new Bills("Fabrieken hebben een nieuwe beter filter nodig voor de schadelijke stoffen in de rook", -2, 0, 2, 0, 2, 0, -2, 0, false, temp));
        myBills.Add(new Bills("De wereldfinale van voetbal moet in jouw stad gehouden worden", 3, -3, -1, 1, -2, 1, 1, -1,false,temp));
        myBills.Add(new Bills("De politie eist betere uitrusting voor hun werk", -2, 2, 0, 0, 2, -2, 0, 0, false, temp));
        myBills.Add(new Bills("In verband met een voetbalwedstrijd in jouw stad is er extra versterking van politie nodig", -2, 2, 0, 0, -2, -2, 0, 0, false, temp));
        myBills.Add(new Bills("Door een groeiende interesse in E-sport is er een stadium nodig om toernooien te organizeren", -1, 1, -1, 2, 1, -1, 0, 0, true, temp));



       

    }
}
