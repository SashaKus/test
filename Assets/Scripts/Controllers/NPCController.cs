using System.Collections;
using System.Collections.Generic;
using UnityEngine;

<<<<<<< Updated upstream
<<<<<<< Updated upstream
public class NPCController : MonoBehaviour/*, ISerializationCallbackReceiver*/
{
    public NPCState[] nPCs;
    DialogueController dialogueController;

    // private Dictionary<ANPC, NPCState> nPCs;

    // [SerializeField] private List<ANPC> nPC;
    // [SerializeField] private List<NPCState> States;

    //public void OnBeforeSerialize()
    //{

    //}

    //public void OnAfterDeserialize()
    //{
    //  //  nPCs = new Dictionary<ANPC, NPCState>();

    //   // for (int i = 0; i != System.Math.Min(nPC.Count, States.Count); i++)
    //     //   nPCs.Add(nPC[i], States[i]);
    //}
=======
=======
>>>>>>> Stashed changes
public class NPCController : MonoBehaviour
{
    public NPCState[] nPCs;
    public DialogueController dialogueController;
<<<<<<< Updated upstream
>>>>>>> Stashed changes
=======
>>>>>>> Stashed changes

    private void Start()
    {
        dialogueController = GameManager.UI.GetComponentInChildren<DialogueController>();
    }

<<<<<<< Updated upstream
<<<<<<< Updated upstream

=======
>>>>>>> Stashed changes
=======
>>>>>>> Stashed changes
    public void StopDialog()
    {
        dialogueController.StopDialog();
    }

<<<<<<< Updated upstream
<<<<<<< Updated upstream
    public void StartDialogue(int i)
    {
        dialogueController.StartDialog(GetSentence(i));
=======
    public void StartDialogue(int i, Sprite interlocutorSprite)
    {
        dialogueController.StartDialog(GetSentence(i), interlocutorSprite);
>>>>>>> Stashed changes
=======
    public void StartDialogue(int i, Sprite interlocutorSprite)
    {
        dialogueController.StartDialog(GetSentence(i), interlocutorSprite);
>>>>>>> Stashed changes
    }

    public void SetStartSentence(int i, ADialogueSentence sentence)
    {
        nPCs[i].startDialogueSentence = sentence;
    }

    public ADialogueSentence GetSentence(int i)
    {
        return nPCs[i].startDialogueSentence;
    }
<<<<<<< Updated upstream
<<<<<<< Updated upstream

=======
>>>>>>> Stashed changes
=======
>>>>>>> Stashed changes
}
[System.Serializable]
public class NPCState
{
    public bool isDead;
    public ADialogueSentence startDialogueSentence;
<<<<<<< Updated upstream
<<<<<<< Updated upstream
=======
=======
>>>>>>> Stashed changes
    [SerializeField] private ADialogueSentence defaultDialogueSentence;

    public void SetDefault()
    {
        isDead = false;
        startDialogueSentence = defaultDialogueSentence;
    }
<<<<<<< Updated upstream
>>>>>>> Stashed changes
=======
>>>>>>> Stashed changes
}