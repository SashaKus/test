using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "BranchingDialogueSentence")]
public class BranchingDialogueSentence : ADialogueSentence
{

    public DialogueChoise[] dialogueChoises;
    private void Awake()
    {
        type = "Branching";

    }

}

[System.Serializable]
public class DialogueChoise
{
    public string answer;
    public ADialogueSentence nextSentence;

    public delegate void OnChoise();
    public event OnChoise onChoise;


    //public delegate void SetStartSentence(int i, ADialogueSentence sentence);
    //public event SetStartSentence setStartSentence;

    public void DoChoise()
    {
        onChoise?.Invoke();
        //setStartSentence?.DynamicInvoke();

    }
}