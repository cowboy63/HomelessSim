using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Speech : MonoBehaviour {

    public Canvas SP;
    public Button next;
    public Text text;


    int index = 0;

    string[] speech = {
        "Hello there brave one",
        "My name is Rem and I \n will be your tutor",
        "You goal in this game \n is to survive the \n waves of enemy troops",
        "You must not let them \n destroy your base",
        "To achieve this you will \n use your army \n position your troops\n by clicking on them \n and clicking the square \n where you would like \n to place them",
        "Kill enemy units to earn \n XP and money \n this will be use to upgrade \n and buy units",
        "Lastly use your arrow keys\n to move the camera \n around",
        "Be careful and good luck!"};
   

    // Use this for initialization
    void Start () {
        SP = SP.GetComponent<Canvas>();
        next = next.GetComponent<Button>();
        text = text.GetComponent<Text>();

        text.text = speech[index];
	}

    public void pressN()
    {
        index++;
        if (index==speech.Length)
        {
            SP.enabled = false;
            text.enabled = false;
            next.enabled = false;
        }
       
        if(index < speech.Length)
        {
            text.text = speech[index];
        }
        
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
