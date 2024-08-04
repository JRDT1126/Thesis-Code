using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//the Item class but specifically used for the Vertical versions of the game
public class ItemVertical : MonoBehaviour
{
    [SerializeField] GameObject highlighter;
    [SerializeField] OrderArrangeVertical control;
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
