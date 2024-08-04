using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

using System.Threading;

//this class deals with generating the order of the pairs and the functions that check if the win condition is met
public class PairManager : MonoBehaviour
{
    [SerializeField] Circle l1, l2, l3, l4, r1, r2, r3, r4;
    [SerializeField] GameObject a1,b1,c1,d1,a2,b2,c2,d2;
    [SerializeField] Canvas canvas, canvas2;

    int[] leftArray = { 0, 1, 2, 3 };
    Circle[] left = new Circle[4];
    Circle[] right = new Circle[4];
    int[] rightArray = {0, 1, 2, 3};

    void Start()
    {
        leftArray = ShuffleArray(leftArray);
        rightArray = ShuffleArray(rightArray);
        int i = 0;
        while(i< leftArray.Length)
        {
            int currentLeftCount = leftArray[i];
            int currentRightCount = rightArray[i];
            switch (currentLeftCount)
            {
                case 0:
                    left[i] = l1;
                    
                    break;
                case 1:
                    left[i] = l2;
                    
                    break;
                case 2:
                    left[i] = l3;
                    
                    break;
                case 3:
                    left[i] = l4;
                    
                    break;
            }
            left[i].GetComponent<Circle>().pairIdentity = i;
            switch (left[i].GetComponent<Circle>().pairIdentity)
            {
                case 0:
                    left[i].photo = a1; 
                    break;
                case 1:
                    left[i].photo = b1; 
                    break;
                case 2:
                    left[i].photo = c1; 
                    break;
                case 3:
                    left[i].photo = d1; 
                    break;
            }
            switch (currentRightCount)
            {
                case 0:
                    right[i] = r1;
                    break;
                case 1:
                    right[i] = r2;
                    break;
                case 2:
                    right[i] = r3;
                    break;
                case 3:
                    right[i] = r4;
                    break;
            }
            right[i].GetComponent<Circle>().pairIdentity = i;
            switch (right[i].GetComponent<Circle>().pairIdentity)
            {
                case 0:
                    right[i].photo = a2;
                    break;
                case 1:
                    right[i].photo = b2;
                    break;
                case 2:
                    right[i].photo = c2;
                    break;
                case 3:
                    right[i].photo = d2;
                    break;
            }
            i++;
        }
        int j = 0;
        while(j< leftArray.Length)
        {
            left[j].gameObject.SetActive(true);
            right[j].gameObject.SetActive(true);
            j++;
        }
    }

    public Circle returnPair(int pairIdentity, bool leftBool)
    {
        Circle returnCircle = new Circle();
        int i = 0;
        if (leftBool)
        {
            while (i < rightArray.Length)
            {
                if (pairIdentity == right[i].GetComponent<Circle>().pairIdentity)
                {
                    returnCircle = right[i];
                    return returnCircle;
                }
                    i++;
            }
        }else
        {
            while (i < leftArray.Length) {
                if (pairIdentity == left[i].GetComponent<Circle>().pairIdentity)
                {
                    returnCircle = left[i];
                    return returnCircle;
                }

                i++;
            }
        }

        return returnCircle;
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
    private Circle first;
    private Circle second;
    [SerializeField] private TextMesh score;
    private int scoreNum = 4;
    public bool pairCheckCondition
    {
        get { return second == null; }
    }

    public void circleRevealed(Circle circle,bool left)
    {
        if (first == null)
        {
            first = circle;
            circle.photo.SetActive(true);
        }
        else
        {
            if(first.left != circle.left)
            {
                second = circle;
                circle.photo.SetActive(true);
                StartCoroutine(pairCheck());
            }
            else
            {
                circle.highlight.SetActive(false);
            }
            
            
        }
    }

    private IEnumerator pairCheck()
    {
        if (first.pairIdentity == second.pairIdentity)
        {
            scoreNum--;

            score.text = "Pairs Left: " + scoreNum;
            yield return new WaitForSeconds(0.2f);
            first.highlight.gameObject.SetActive(false);
            
            
            second.highlight.gameObject.SetActive(false);
            first.photo.SetActive(false);
            second.photo.SetActive(false);
            first.gameObject.SetActive(false);
            second.gameObject.SetActive(false);
            

        }
        else
        {
            yield return new WaitForSeconds(0.5f);
            first.photo.SetActive(false);
            second.photo.SetActive(false);
            first.highlight.gameObject.SetActive(false);


            second.highlight.gameObject.SetActive(false);
        }

        first = null;
        second = null;

        if (scoreNum == 0)
        {
            canvas.gameObject.SetActive(false);
            canvas2.gameObject.SetActive(true);

        }
    }
}
