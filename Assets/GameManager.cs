using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Yarn.Unity;

public class GameManager : MonoBehaviour
{
    [SerializeField] GameObject[] book;
    public bool canInteract = false;
    [SerializeField] DialogueRunner dialogueRunner;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ChangePage(int pageNumber)
    {
        foreach (var page in book)
        {
            page.SetActive(false);
        }
        book[pageNumber].SetActive(true);
        canInteract = true;
    }

    public void RunDialogue(string dialogue)
    {
        dialogueRunner.StartDialogue(dialogue);
        canInteract = false;
    }

}
