using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

using System.Threading;

//this class sets up the Ishihara minigames, shuffling them into a randomized order and location
public class ItemTracker : MonoBehaviour
{
    [SerializeField] Ishihara ishi1,ishi2,ishi3,ishi4;
    [SerializeField] Sprite a1, a2, a3,  b1, b2, b3,  c1, c2, c3, d1, d2, d3,e1,e2,e3,f1,f2,f3,g1,g2,g3,h1,h2,h3,i1,i2,i3;
    [SerializeField] Canvas canvas, canvas2;

    int[] ishiNumArray = { 0, 1, 2, 3 };
    int[] spriteNumArray = { 0, 1, 2, 3, 4, 5, 6, 7, 8 };
    Sprite[] aArray, bArray,cArray,dArray,eArray,fArray,hArray,iArray;

    Ishihara[] ishiArray = new Ishihara[4];
    int oddIdentity;
    int winCounter;
    // Start is called before the first frame update
    void Start()
    {
        aArray = new Sprite[]{ a1, a2, a3 };
        bArray = new Sprite[] { b1, b2, b3 };
        cArray = new Sprite[] {c1,c2, c3 };
        dArray = new Sprite[] {d1, d2, d3 };
        eArray = new Sprite[] {e1, e2, e3 };
        fArray = new Sprite[] {f1, f2, f3 };
        hArray = new Sprite[] {h1, h2, h3 };
        iArray = new Sprite[] {i1, i2, i3 };

        StageSetup();
    }
    public void StageSetup()
    {
        if(winCounter < 4)
        {
            //clears the current array
            ishiArray = new Ishihara[4];

            //determines the pattern from the current stage and removes it from the next stages
            ishiNumArray = ShuffleArray(ishiNumArray);
            spriteNumArray = ShuffleArray(spriteNumArray);
            int mainPattern = spriteNumArray[0];
            int oddPattern = spriteNumArray[1];
            

            //assigns the pattern for the stage
            Sprite[] oddArray = aArray;
            Sprite[] mainArray = bArray;
            switch (mainPattern)
            {
                case 0:
                    mainArray = aArray; break;
                case 1:
                    mainArray = bArray; break;
                case 2:
                    mainArray = cArray; break;
                case 3:
                    mainArray = dArray; break;
                case 4:
                    mainArray = eArray; break;
                case 5:
                    mainArray = fArray; break;
                case 6:
                    mainArray = hArray; break;
                case 7:
                    mainArray = iArray; break;
            }

            switch (oddPattern)
            {
                case 0:
                    oddArray = aArray; break;
                case 1:
                    oddArray = bArray; break;
                case 2:
                    oddArray = cArray; break;
                case 3:
                    oddArray = dArray; break;
                case 4:
                    oddArray = eArray; break;
                case 5:
                    oddArray = fArray; break;
                case 6:
                    oddArray = hArray; break;
                case 7:
                    oddArray = iArray; break;
            }

            //odd-one-out
            ishiNumArray = ShuffleArray(ishiNumArray);
            oddIdentity = ishiNumArray[0];
            int i = 0;
            int j = 0;
            //put ishiharas into array and determines the odd one out and sets the sprites for the game;
            while (i < ishiArray.Length)
            {
                switch (i)
                {
                    case 0:
                        ishiArray[i] = ishi1;

                        break;
                    case 1:
                        ishiArray[i] = ishi2;

                        break;
                    case 2:
                        ishiArray[i] = ishi3;

                        break;
                    case 3:
                        ishiArray[i] = ishi4;

                        break;
                }
                ishiArray[i].identity = i;
                ishiArray[i].odd = false;
                if (i == oddIdentity)
                {
                    ishiArray[i].odd = true;
                    ishiArray[i].GetComponent<SpriteRenderer>().sprite = oddArray[0];
                }
                else
                {
                    ishiArray[i].GetComponent<SpriteRenderer>().sprite = mainArray[j];
                    j++;
                }
                i++;
            }
            winCounter++;
        }
        else
        {
            canvas.gameObject.SetActive(false);
            canvas2.gameObject.SetActive(true);
        }



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

    // Update is called once per frame
    void Update()
    {
        
    }
}
