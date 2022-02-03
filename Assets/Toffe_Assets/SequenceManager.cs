using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SequenceManager : MonoBehaviour
{
    //public List<string> correctSequence = new List<string>();                    //Creates a list of strings that's meant to be the right sequence
    public List<string> playerSequence = new List<string>();                     //Creates a list from what the player has clicked from the other list

    private bool checking = false; //Bool that checks if the sequence is correct

    public SequenceCounter sequenceCounter;
    public bool fullSequence;

    public int maxWordAmount;

    void Update()
    {
        /* if (playerSequence.Count == correctSequence.Count && checking == false)      //Checks if the amount of words in the players sequence matches up with the correct sequence
         {
             checking = true;
             //checkSequence();
         }
        */
        if (playerSequence.Count==20)
        {
            fullSequence = true;
        }
    }
       

    public void AddSequence(string mailText) //Adds number to list
    {
        if (playerSequence.Count < maxWordAmount)
        {
            
            playerSequence.Add(mailText);
            sequenceCounter.UpdateText(mailText);
        }
       
    }

    public void FinishedSequence() //Resets sequence
    {
        /*if (fullSequence = true)
        {

        }
        */
        Debug.Log("Reset text sequence");
        //playerSequence.Clear();
        //sequenceCounter.UpdateText();
        //checking = false;
    }

    /*public void checkSequence() //Checks if the correct sequence corresponds with the player sequence
    {
        for (int i=0; i< correctSequence.Count; i++)
        {
            if(correctSequence[i]!= playerSequence[i])
            { ResetSequence();
                return;
            }
        }
    } */
}
