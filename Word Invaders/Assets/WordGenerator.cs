using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WordGenerator : MonoBehaviour {
    
    private static string[] wordList = {
        "bribery", "fraud", "embezzlement", "nepotism", "collusion", "kickbacks", "extortion", "graft", "patronage", "payoffs", "racketeering", "blackmail", "skimming", "favors", "bribes", "cronyism", "lobbying", "favoritism", "smuggling", "kleptocracy", "oligarchy", "clientelism", "drugs", "debt"
    };
    
    public static string GetRandomWord() {
        int randomIndex = Random.Range(0, wordList.Length);
        string randomeWord = wordList[randomIndex];
        return randomeWord;
    }
}
