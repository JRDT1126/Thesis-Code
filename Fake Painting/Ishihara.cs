using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

//this class simply checks if an item is the odd man out, if so it calls for the win condition to be activated
public class Ishihara : MonoBehaviour
{
    [SerializeField] public int identity;
    [SerializeField] public bool odd;
    [SerializeField] public ItemTracker tracker;
    // Start is called before the first frame update
    public void OnMouseDown()
    {
        if (odd)
        {
            tracker.StageSetup();
        }
    }


}
