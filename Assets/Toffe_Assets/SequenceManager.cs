using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SequenceManager : MonoBehaviour
{
    public List<string> playerSequence = new List<string>();                     //Creates a list from what the player has clicked from the other list
    private bool checking = false;                                               //Bool that checks if the sequence is correct

    public SequenceCounter sequenceCounter;
    public bool fullSequence;
    public int maxWordAmount;

    public GameObject SequenceFinishedText;
    public bool clearText;
    


    void Update()
    {
       
        if (playerSequence.Count == maxWordAmount)
        {
            fullSequence = true;
        }

        if (fullSequence == true)
        {
            FinishedSequence();
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
        SequenceFinishedText.SetActive(true);
        
        Debug.Log("Reset text sequence");   
       
    }

    public void Yes()
    {
        //code
        SceneManager.LoadScene(0);
    }

    public void No()
    {
        SceneManager.LoadScene(0);
    }

    
}
