using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DialogueManager : MonoBehaviour
{
    public float typingSpeed;
    public float slowSpeed;
    public float normalSpeed;

    public Queue<Character> characters;
    private Character currentCharacter;

    public TextMeshProUGUI textDisplay;
    public string[] sentences;
    private int index;
    

    public GameObject continueButton;

    void Start()
    {
        
    }

    void Update()
    {
        if (textDisplay.text ==sentences[index])
        {
            continueButton.SetActive(true);
        }
    }

    IEnumerator Type()
    {
        foreach(char letter in sentences[index].ToCharArray())
        {
            textDisplay.text += letter;
            yield return new WaitForSeconds(0.02f);
        }
    }

    public void NextSentence()
    {
        continueButton.SetActive(false);
        if(index < sentences.Length - 1)
        {
            index++;
            textDisplay.text = "";
            StartCoroutine(Type());
        }
        else
        {
            textDisplay.text = "";
            continueButton.SetActive(false);
        }
    }

    public void TriggerDialogue()
    {
        StartCoroutine(Type());
    }
}
