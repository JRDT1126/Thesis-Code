using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

using static UnityEngine.ParticleSystem;

//the class that arranges the randomized pieces for the player to fix
//this version is specifically for the vertical version of the games
public class OrderArrangeVertical : MonoBehaviour
{
    [SerializeField] ItemVertical b1, b2, b3, b4, b5, b6, b7, b8, b9;
    [SerializeField] GameObject staticS;
    [SerializeField] Canvas canvas, canvas2;
    ItemVertical[] originalArray = new ItemVertical[9];
    ItemVertical[] newObjectArray = new ItemVertical[9];
    int[] ogArrayNumbers;
    int[] newArrayNumbers;
    string[] originalarrayID;
    private void Start()
    {

        ogArrayNumbers = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        originalArray = new ItemVertical[] { b1, b2, b3, b4, b5, b6, b7, b8, b9 };


        newObjectArray = ShuffleArrayObject(originalArray);
        ShufflePosition(originalArray, newObjectArray);


    }


    private ItemVertical[] ShuffleArrayObject(ItemVertical[] objectArray)
    {
        ItemVertical[] newArray = objectArray.Clone() as ItemVertical[];
        int[] newArrayTemp = ogArrayNumbers.Clone() as int[];
        int i = 0;
        while (i < newArray.Length)
        {
            ItemVertical temp = newArray[i];
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

    private void ShufflePosition(ItemVertical[] originalArray, ItemVertical [] newArray)
    {
        int i = 0;
        Vector3[] holderArray = new Vector3[originalArray.Length];
        while (i < originalArray.Length)
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

    private ItemVertical item1;
    private ItemVertical item2;

    public bool itemCheckCondition
    {
        get { return item2 == null; }
    }

    public void itemChecker(ItemVertical item)
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
        float staticPosition = staticS.transform.position.y;
        float b1Position = b1.transform.position.y;
        float b2Position = b2.transform.position.y;
        float b3Position = b3.transform.position.y;
        float b4Position = b4.transform.position.y;
        float b5Position = b5.transform.position.y;
        float b6Position = b6.transform.position.y;
        float b7Position = b7.transform.position.y;
        float b8Position = b8.transform.position.y;
        float b9Position = b9.transform.position.y;

        if (b9Position > b8Position && b8Position > b7Position && b7Position > b6Position && b6Position > b5Position && b5Position > b4Position && b4Position > b3Position && b3Position > b2Position && b2Position > b1Position)
        {
            canvas.gameObject.SetActive(false);
            canvas2.gameObject.SetActive(true);
        }

    }
}
