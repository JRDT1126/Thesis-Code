using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//the Item class that is to be arranged by the player, affected by mouse clicking and functions that return the information of the item
public class Item : MonoBehaviour
{
    [SerializeField] GameObject highlighter;
    [SerializeField] OrderArranger control;
    [SerializeField] string signal;
    

    public void OnMouseDown()
    {
        if (!highlighter.activeSelf && control.itemCheckCondition)
        {
            highlighter.SetActive(true);
            control.itemChecker(this);
        }
    }

    
    public void Hide()
    {
        highlighter.SetActive(false);
    }

    public string getID()
    {
        return signal;
    }
}
