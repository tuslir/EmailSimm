using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class SequenceCounter : MonoBehaviour
{
    private TextMeshProUGUI displayedText;
    public SequenceManager manager;
    

    

    void Start()
    {
        displayedText = GetComponent<TextMeshProUGUI>();
        
        
    }

    
    public void UpdateText(string newText)
    {
        
            displayedText.text = displayedText.text + newText;
        /*  if (manager.clearText == true)
        {
            StartCoroutine(resetText());
            manager.clearText = false;
        }
        

        

       IEnumerator resetText()
         {
             
             yield return new WaitForSeconds(0);
             displayedText.text
         } 
        */


    }
}
