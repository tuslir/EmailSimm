using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SequenceManager : MonoBehaviour
{
    public List<int> correctSequence = new List<int>();                    //Creates a list of strings that's meant to be the right sequence
    public List<int> playerSequence = new List<int>();                     //Creates a list from what the player has clicked from the other list

    private bool checking = false; //Bool that checks if the sequence is correct

    public SequenceCounter sequenceCounter;

    void Update()
    {
        if (playerSequence.Count == correctSequence.Count && checking == false)      //Checks if the amount of words in the players sequence matches up with the correct sequence
        {
            checking = true;
            checkSequence();
        }
    }

    public void AddSequence(int mailText) //Adds string to list
    {
        playerSequence.Add(mailText);
        sequenceCounter.UpdateText();
    }

    public void ResetSequence() //Resets sequence
    {
        Debug.Log("Reset text sequence");
        checking = false;
        playerSequence.Clear();
        sequenceCounter.UpdateText();
    }

    public void checkSequence() //Checks if the correct sequence corresponds with the player sequence
    {
        for (int i=0; i< correctSequence.Count; i++)
        {
            if(correctSequence[i]!= playerSequence[i])
            { ResetSequence();
                return;
            }
        }
    } 
}
