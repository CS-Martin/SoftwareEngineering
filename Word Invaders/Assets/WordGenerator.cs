using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WordGenerator : MonoBehaviour {
    
    private static string[] wordList = {
        "slope", "announce", "drink", "baby", "watch", "grieving", "depend", "fang", "innate", "one", "experience", "authority", "dependent", "lying", "reminiscent", "momentous", "ugly", "sisters", "receive", "unable", "guard", "brick", "north", "air", "abiding", "mint", "spicy", "sick", "supply", "snake", "spiky", "bewildered", "education", "wander", "watery", "gamy", "wax", "toe", "rest", "wiry", "gaping", "rich", "judge", "cellar", "trite", "peace", "many", "truculent", "crime", "turkey"
    };
    
    public static string GetRandomWord() {
        int randomIndex = Random.Range(0, wordList.Length);
        string randomeWord = wordList[randomIndex];
        return randomeWord;
    }
}
