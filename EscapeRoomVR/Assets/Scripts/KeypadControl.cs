using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeypadControl : MonoBehaviour {

    //public KeypadKeys keys = new KeypadKeys[12];

    public List<KeypadKeys> keys;
    private string correctCode = "3796";
    private string userEntry;
    public LootCrate _lootCrate;
    public TextMesh textBox;


    // Use this for initialization
    void Start () {
        userEntry = "";
        //textBox = gameObject.GetComponent("TextMesh") as TextMesh;
        textBox.text = userEntry;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void updateEntry (string newEntry)
    {
        if(newEntry == "CLEAR")
        {
            userEntry = "";
        }
        else if(newEntry == "ENTER")
        {
            if(userEntry.Length < 4)
            {
                //Error sound, password too short
            }
            else
            {
                checkAnswer();
            }
        }
        else if(userEntry.Length < 4)
        {
            //Add a sound for when a number is entered
            userEntry += newEntry;
        }
        else
        {
            //Sound for when the entry is full
        }

        textBox.text = userEntry;
    }

    void checkAnswer ()
    {
        if(userEntry == correctCode)
        {
            _lootCrate.Open();
        }
        else
        {
            //Error sound
            userEntry = "";
            textBox.text = userEntry;
        }
    }

}
