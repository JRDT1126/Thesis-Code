using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

using static UnityEngine.ParticleSystem;
//same as OrderArrangeVertical but for the other Hue Test Minigames with horizontal arrangements
public class OrderArranger : MonoBehaviour
{
    [SerializeField] Item b1,b2,b3,b4,b5,b6,b7,b8,b9;
    [SerializeField] GameObject staticS;
    [SerializeField] Canvas canvas, canvas2;
    Item[] originalArray = new Item[9];
    Item[] newObjectArray = new Item[9];
    int[] ogArrayNumbers;
    int[] newArrayNumbers;
    string[] originalarrayID;
    private void Start()
    {

        ogArrayNumbers = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9};
        originalArray = new Item[] { b1,b2,b3,b4,b5,b6,b7,b8,b9};

        
        newObjectArray = ShuffleArrayObject(originalArray);
        ShufflePosition(originalArray, newObjectArray);
        

    }

    
    private Item[] ShuffleArrayObject(Item[] objectArray)
    {
        Item[] newArray = objectArray.Clone() as Item[];
        int[] newArrayTemp = ogArrayNumbers.Clone() as int[];  
        int i = 0;
        while (i < newArray.Length)
        {
            Item temp = newArray[i];
            int tempNum = newArrayTemp[i];
            int r = UnityEngine.Random.Range(i, newArray.Length);
            newArray[i] = newArray[r];
            newArrayTemp[i] = newArrayTemp[r];
            newArrayTemp[r] = tempNum;
            newArray[r] = temp;
            i++;
        }
        newArrayNumbers = newArrayTemp;
        return newArray;
    }

    private void ShufflePosition(Item[] originalArray, Item[] newArray)
    {
        int i = 0;
        Vector3[] holderArray = new Vector3[originalArray.Length];
        while(i < originalArray.Length)
        {
            holderArray[i] = originalArray[i].transform.position;
            i++;
        }

        i = 0;
        while (i < originalArray.Length)
        {
            newArray[i].transform.position = holderArray[i];
            i++;
        }
    }

    private Item item1;
    private Item item2;

    public bool itemCheckCondition
    {
        get { return item2 == null; }
    }

    public void itemChecker(Item item)
    {
        if (item1 == null)
        {
            item1 = item;
        }
        else
        {
            item2 = item;

            StartCoroutine(PositionShift());
        }
    }

    private IEnumerator PositionShift()
    {
        Vector3 temp1 = item1.transform.position;
        Vector3 temp2 = item2.transform.position;
        
        item2.transform.position = temp1;
        item1.transform.position = temp2;

        yield return new WaitForSeconds(0.5f);
        item1.Hide();
        item2.Hide();
        item1 = null;
        item2 = null;

        
    }

    public void winCondition()
    {
        float staticPosition = staticS.transform.position.x;
        float b1Position = b1.transform.position.x;
        float b2Position = b2.transform.position.x;
        float b3Position = b3.transform.position.x;
        float b4Position = b4.transform.position.x;
        float b5Position = b5.transform.position.x;
        float b6Position = b6.transform.position.x;
        float b7Position = b7.transform.position.x;
        float b8Position = b8.transform.position.x;
        float b9Position = b9.transform.position.x;
        
        if(b9Position>b8Position&&b8Position>b7Position&&b7Position>b6Position&&b6Position>b5Position&&b5Position>b4Position&&b4Position>b3Position&&b3Position>b2Position&&b2Position>b1Position){ 
            canvas.gameObject.SetActive(false);
            canvas2.gameObject.SetActive(true);
        }
        
    }


}
