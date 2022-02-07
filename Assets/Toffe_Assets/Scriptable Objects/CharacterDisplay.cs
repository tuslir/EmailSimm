using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CharacterDisplay : MonoBehaviour
{

    public Character character;

    public TextMeshProUGUI nameText;

    public TextMeshProUGUI dialogueText;

    

    void Start()
    {
        character.Print();

        nameText.text = character.name;
        
    }

  
}
