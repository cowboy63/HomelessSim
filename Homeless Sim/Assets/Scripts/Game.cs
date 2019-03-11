using UnityEngine;
using UnityEngine.UI;
using System.Globalization;
using System;
using System.Collections;

public class Game : MonoBehaviour{
    public Canvas gm;
    public Button work;

    public Text money;

    public Canvas workMenu;
    public Canvas honestWorkMenu;
    public Canvas criminalWorkMenu;

    //public Canvas houseMenu;
    //public Canvas healthMenu;
    //public Canvas shopMenu;

    int[] priceCrimnialEducation = new int[] { 500, 1000, 5000, 10000, 50000 };
    int[] priceEducation = new int[] { 5000, 10000, 100000, 500000};

    public long MONEY;

    public Canvas educationMenu;
    public Button educationMenuButton;
    public Button workMenuButton;
    public Canvas formalEducationMenu;
    public Canvas criminalEducationMenu;

    public Canvas shopMenu;

    public Button EMexit;
    public Button EFMexit;
    public Button ECMexit;

    public ArrayList education;
    public ArrayList items;

    public int age;
    public int health;
    public int hunger;

    public long moneyPerP=10;

    ArrayList skills;


	// Use this for initialization
	void Start () {
        
        gm = gm.GetComponent<Canvas>();
        work = work.GetComponent<Button>();
        money = money.GetComponent<Text>();

        skills = new ArrayList();

        educationMenu = educationMenu.GetComponent<Canvas>();
        educationMenuButton = educationMenuButton.GetComponent<Button>();
        formalEducationMenu = formalEducationMenu.GetComponent<Canvas>();
        criminalEducationMenu = criminalEducationMenu.GetComponent<Canvas>();

        workMenu = workMenu.GetComponent<Canvas>();
        honestWorkMenu = honestWorkMenu.GetComponent<Canvas>();
        criminalWorkMenu = criminalWorkMenu.GetComponent<Canvas>();
        workMenuButton = workMenuButton.GetComponent<Button>();

        EMexit = EMexit.GetComponent<Button>();
        EFMexit = EFMexit.GetComponent<Button>();
        ECMexit = ECMexit.GetComponent<Button>();

        shopMenu = shopMenu.GetComponent<Canvas>();

        shopMenu.enabled = false;

        ECMexit.enabled = false;
        EFMexit.enabled = false;
        EMexit.enabled = false;

        criminalWorkMenu.enabled = false;
        honestWorkMenu.enabled = false;
        workMenu.enabled = false;

        
        formalEducationMenu.enabled = false;
        educationMenu.enabled = false;
        criminalEducationMenu.enabled = false;

        MONEY = 10000;

        money.text = "$"+MONEY;

	}

    public void buttonEducationPress(String n )
    {
        foreach(String lol in skills)
        {
            print(lol);
        }
        print(MONEY);
        switch (n){
            case "steal1":
                if(MONEY>=priceCrimnialEducation[0]&&skills.IndexOf(n)==-1)
                {
                    MONEY -= priceCrimnialEducation[0];
                    skills.Add(n);
                }
                break;
            case "steal2":
                if (MONEY >= priceCrimnialEducation[1] && skills.IndexOf(n) == -1)
                {
                    MONEY -= priceCrimnialEducation[1];
                    skills.Add(n);
                }
                break;
            case "hacking":
                if (MONEY >= priceCrimnialEducation[2] && skills.IndexOf(n) == -1)
                {
                    MONEY -= priceCrimnialEducation[2];
                    skills.Add(n);
                }
                break;
            case "drugs":
                if (MONEY >= priceCrimnialEducation[3] && skills.IndexOf(n) == -1)
                {
                    MONEY -= priceCrimnialEducation[3];
                    skills.Add(n);
                }
                break;
            case "assasin":
                if (MONEY >= priceCrimnialEducation[4] && skills.IndexOf(n) == -1)
                {
                    MONEY -= priceCrimnialEducation[4];
                    skills.Add(n);
                }
                break;
            case "HS":
                if (MONEY >= priceEducation[0] && skills.IndexOf(n) == -1)
                {
                    MONEY -= priceEducation[0];
                    skills.Add(n);
                }
                break;
            case "CC":
                if (MONEY >= priceEducation[1] && skills.IndexOf(n) == -1)
                {
                    MONEY -= priceEducation[1];
                    skills.Add(n);
                }
                break;
            case "4YU":
                if (MONEY >= priceEducation[2] && skills.IndexOf(n) == -1)
                {
                    MONEY -= priceEducation[2];
                    skills.Add(n);
                }
                break;
            case "MS":
                if (MONEY >= priceEducation[3] && skills.IndexOf(n) == -1)
                {
                    MONEY -= priceEducation[3];
                    skills.Add(n);
                }
                break;
            case "LS":
                if (MONEY >= priceEducation[3] && skills.IndexOf(n) == -1)
                {
                    MONEY -= priceEducation[3];
                    skills.Add(n);
                }
                break;
            case "BS":
                if (MONEY >= priceEducation[3] && skills.IndexOf(n) == -1)
                {
                    MONEY -= priceEducation[3];
                    skills.Add(n);
                }
                break;
        }

        money.text = "$" + String.Format("{0:0,0}", MONEY);

    }
    public void criminalEducationPress()
    {
        if (!criminalEducationMenu.enabled)
        {
            criminalEducationMenu.enabled = true;
            ECMexit.enabled = true;
        }
        else
        {
            criminalEducationMenu.enabled = false;
            ECMexit.enabled = false;
        }
    }
    public void formalEducationButtonPress()
    {
        if(!formalEducationMenu.enabled)
        {
            formalEducationMenu.enabled = true;
            EFMexit.enabled = true;
        }
        else
        {
            formalEducationMenu.enabled = false;
            EFMexit.enabled = false;
        }
    }
    public void educationButtonPress()
    {
        if (!educationMenu.enabled)
        {
            educationMenu.enabled = true;
            EMexit.enabled = true;
        }
        else
        {
            educationMenu.enabled = false;
            EMexit.enabled = false;
        }
    }
    public void workButtonPress()
    {
        if (!workMenu.enabled)
        {
            workMenu.enabled = true;
            EMexit.enabled = true;
        }
        else
        {
            workMenu.enabled = false;
            EMexit.enabled = false;
        }
    }
    public void honestWorkButtonPress()
    {
        if (!honestWorkMenu.enabled)
        {
            honestWorkMenu.enabled = true;
            EMexit.enabled = true;
        }
        else
        {
            honestWorkMenu.enabled = false;
            EMexit.enabled = false;
        }
    }
    public void shopButtonPress()
    {
        if (!shopMenu.enabled)
        {
            shopMenu.enabled = true;
            EMexit.enabled = true;
        }
        else
        {
            shopMenu.enabled = false;
            EMexit.enabled = false;
        }
    }
    public void criminalWorkButtonPress()
    {
        if (!criminalWorkMenu.enabled)
        {
            criminalWorkMenu.enabled = true;
            EMexit.enabled = true;
        }
        else
        {
            EMexit.enabled = false;
            criminalWorkMenu.enabled = false;
        }
    }
    public void ExitPress()
    {
        EFMexit.enabled = false;
        ECMexit.enabled = false;
        criminalEducationMenu.enabled = false;
        EMexit.enabled = false;
        workMenu.enabled = false;
        educationMenu.enabled = false;
        formalEducationMenu.enabled = false;
        workMenu.enabled = false;
        shopMenu.enabled = false;
        honestWorkMenu.enabled = false;
        criminalWorkMenu.enabled = false;
    }

    public void Work(String n, Boolean criminalJob, int strainHealth , int strainHunger, int amountEarned)
    {
        if(!criminalJob)
        {
            switch (n)
            {
                case "beg":
                    Work(amountEarned);
                    health -= strainHealth;
                    hunger -= strainHunger;
                    break;
                case "carW":
                    //REPLACE TRUE WITH IF THEY HAVE SHOES
                    if(true)
                    {
                        Work(amountEarned);
                        health -= strainHealth;
                        hunger -= strainHunger;
                    }
                    break;
                case "cashier":
                    if (skills.Contains("HS"))
                    {
                        Work(amountEarned);
                        health -= strainHealth;
                        hunger -= strainHunger;
                    }
                    break;
                case "plummer":
                    if (skills.Contains("CC"))
                    {
                        Work(amountEarned);
                        health -= strainHealth;
                        hunger -= strainHunger;
                    }
                    break;
                case "accountant":
                    if (skills.Contains("4YU"))
                    {
                        Work(amountEarned);
                        health -= strainHealth;
                        hunger -= strainHunger;
                    }
                    break;
                case "doctor":
                    if (skills.Contains("MS"))
                    {
                        Work(amountEarned);
                        health -= strainHealth;
                        hunger -= strainHunger;
                    }
                    break;
                case "lawyer":
                    if (skills.Contains("LS"))
                    {
                        Work(amountEarned);
                        health -= strainHealth;
                        hunger -= strainHunger;
                    }
                    break;
                case "ceo":
                    if (skills.Contains("BS"))
                    {
                        Work(amountEarned);
                        health -= strainHealth;
                        hunger -= strainHunger;
                    }
                    break;
            }
        }
        else
        {

        }
    }

    public void Work(int moneyPerP)
    {
        CultureInfo culture = null;
        culture = CultureInfo.CreateSpecificCulture("en-US");
        MONEY += moneyPerP;
        money.text = "$"+String.Format("{0:0,0}", MONEY);
    }
	// Update is called once per frame
	void Update () {
	
	}
}