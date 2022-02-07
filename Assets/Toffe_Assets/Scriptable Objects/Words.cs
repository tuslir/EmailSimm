using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Wordlist", menuName = "words")]
public class Words : ScriptableObject
{
    public List<string> words = new List<string>();
}
