using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SequenceCounter : MonoBehaviour
{
    private Text displayedText;
    public SequenceManager sequence;
    private bool wrongSequence = false;

    void Start()
    {
        displayedText = GetComponent<Text>();
        
    }

    
    public void UpdateText()
    {
        switch (sequence.playerSequence.Count)
        {
            case 1:
                displayedText.text = sequence.playerSequence[0].ToString();
                return;
            case 2:
                displayedText.text = sequence.playerSequence[0].ToString() +
                    sequence.playerSequence[1];
                return;
            case 3:
                displayedText.text = sequence.playerSequence[0].ToString() +
                   sequence.playerSequence[1] +
                   sequence.playerSequence[2];
                return;
            case 4:
                displayedText.text = sequence.playerSequence[0].ToString() +
                   sequence.playerSequence[1] +
                   sequence.playerSequence[2] +
                   sequence.playerSequence[3];
                return;

            default:
                if (!wrongSequence)
                {
                    wrongSequence = true;
                    
                }
                return;

        }


    }
}
