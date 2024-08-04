using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//this Circle class is the main item for the DNA matching minigame, with one function allowing to check for the win condition by calling a function by the PairManager
public class Circle : MonoBehaviour
{
    [SerializeField] PairManager pairManager;
    public GameObject photo;
    [SerializeField] public GameObject highlight;
    public int pairIdentity;
    public bool left;

    public void OnMouseDown()
    {
        highlight.SetActive(true);
        if (highlight.activeSelf && pairManager.pairCheckCondition)
        {
            
            pairManager.circleRevealed(this,left);
            
            
        }
    }


    void Update()
    {
        

    }
}
