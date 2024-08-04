using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

//the main class that randomizes the order and picks which games the player will go through in a single run
//this class also pushes data to the next GameController in a scene to make sure that the order of games generated is followed
public class GameController : MonoBehaviour
{
   

    public void Beginning()
    {
        
        int[] fArray = new int[] { 1, 2, 3, 4 };
        fArray = ShuffleArray(fArray);
        int[] sArray = new int[] { 5, 6, 7, 8 };
        sArray = ShuffleArray(sArray);
        int[] tArray = new int[] { 9, 10, 11, 12 };
        tArray = ShuffleArray(tArray);
        int[] foArray = new int[] { 13, 14, 15 };
        foArray = ShuffleArray(foArray);


        int[] newSceneArray = new int[8];

        newSceneArray[0] = fArray[0];
        newSceneArray[1] = fArray[1];
        newSceneArray[2] = sArray[0];
        newSceneArray[3] = sArray[1];
        newSceneArray[4] = tArray[0];
        newSceneArray[5] = tArray[1];
        newSceneArray[6] = foArray[0];
        newSceneArray[7] = foArray[1];

        newSceneArray = ShuffleArray(newSceneArray);

        StaticData.sceneOrder = newSceneArray;
        StaticData.sceneIterator = 0;
        SceneManager.LoadScene(StaticData.sceneOrder[StaticData.sceneIterator]);



        
    }
    

    

    private int[] ShuffleArray(int[] numbers)
    {
        int[] newArray = numbers.Clone() as int[];
        int i = 0;
        while (i < newArray.Length)
        {
            int temp = newArray[i];
            int r = Random.Range(i, newArray.Length);
            newArray[i] = newArray[r];
            newArray[r] = temp;
            i++;
        }
        return newArray;
    }
    public void MoveToScene()
    {
        StaticData.sceneIterator++;
        if(StaticData.sceneIterator < StaticData.sceneOrder.Length)
        {
            SceneManager.LoadScene(StaticData.sceneOrder[StaticData.sceneIterator]);
        }
        else
        {

            ReturntoOrigin();
        }
        
    }

    public void ReturntoOrigin()
    {
        SceneManager.LoadScene(0);
    }

    
}
