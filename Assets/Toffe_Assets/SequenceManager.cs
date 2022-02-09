using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class SequenceManager : MonoBehaviour
{
    public List<string> playerSequence = new List<string>();                     //Creates a list from what the player has clicked from the other list

    public SequenceCounter sequenceCounter;
    public bool fullSequence;
    public int maxWordAmount;

    [Header("Public objects")]
    public TextMeshProUGUI userInputTMP;
    public GameObject SequenceFinishedText;
    public GameObject pic;

    public bool clearText;
    public bool flashed = false;


    void Update()
    {
       
        if (playerSequence.Count == maxWordAmount)
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

        if (flashed == false)
        {
            userInputTMP.text = string.Empty;
            playerSequence.Clear();
            SequenceFinishedText.SetActive(false);
            StartCoroutine(FlashPic());
        }
        else
        {
            userInputTMP.text = string.Empty;
            playerSequence.Clear();
            SequenceFinishedText.SetActive(false);
        }
    }

    public void No()
    {
        userInputTMP.text = string.Empty;
        playerSequence.Clear();
        SequenceFinishedText.SetActive(false);
    }

    IEnumerator FlashPic()
    {

        yield return new WaitForSeconds(1);
        pic.SetActive(true);
        yield return new WaitForSeconds(0.05f);
        pic.SetActive(false);
        flashed = true;

         }

}
