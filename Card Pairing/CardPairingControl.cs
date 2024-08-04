using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;


//the script that allows full checking if the win conditions have been met
public class CardPairingControl : MonoBehaviour
{
    public const int columns = 5;
    public const int rows = 2;
    public const float offsetX = 3.25f;
    public const float offsetY = 4f;

    [SerializeField] private Card originCard;
    [SerializeField] private Sprite[] images;
    [SerializeField] public AudioSource fail;
    [SerializeField] public AudioSource success;
    [SerializeField] public Canvas canvas1;
    private void Start()
    {
        //rearranges the cards and display them in a random order
        Vector3 startPos = originCard.transform.position;
        int[] numbers = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9};
        numbers = ShuffleArray(numbers);
        int i = 0;
        
        while ( i < columns)
        {
            int j = 0;
            while (j < rows)
            {
                Card card;
                if(i == 0 && j == 0)
                {
                    card = originCard;
                }
                else
                {
                    card = Instantiate(originCard) as Card;
                }

                int index = j * columns + i;
                int id = numbers[index];

                string newType = "blank";
                switch (id)
                {
                    case 0:
                        newType = "four";
                        break;
                    case 1:
                        newType = "four";
                        break;
                    case 2:
                        newType = "ham";
                        break;
                    case 3:
                        newType = "ham";
                        break;
                    case 4:
                        newType = "sim";
                        break;
                    case 5:
                        newType = "sim";
                        break;
                    case 6:
                        newType = "star";
                        break;
                    case 7:
                        newType = "star";
                        break;
                    case 8:
                        newType = "triangle";
                        break;
                    case 9:
                        newType = "triangle";
                        break;
                }
                card.ChangeSprite(id, images[id],newType);

                float posX = (offsetX * i) + startPos.x;
                float posY = (offsetY * j) + startPos.y;
                card.transform.position = new Vector3(posX, posY, startPos.z);

                j++;
            }
            i++;
        }
    }

    //shuffles an array for use
    private int[] ShuffleArray(int[] numbers)
    {
        int[] newArray = numbers.Clone() as int[];
        int i = 0;
        while(i < newArray.Length)
        {
            int temp = newArray[i];
            int r = Random.Range(i, newArray.Length);
            newArray[i] = newArray[r];
            newArray[r] = temp;
            i++;
        }
        return newArray;
    }

    //checks for the win condition
    private Card first;
    private Card second;
    [SerializeField] private TextMesh score;
    private int scoreNum = 0;

    public bool pairCheckCondition
    {
        get { return second == null; }
    }
    public void cardRevealed(Card card)
    {
        if(first == null)
        {
            first = card;
        }
        else
        {
            second = card;
            
            StartCoroutine(pairCheck());
        }
    }

    private IEnumerator pairCheck()
    {
        if(first.type == second.type)
        {
            scoreNum++;
            
            score.text = "Score: " + scoreNum;
            success.Play();
        }
        else
        {
            yield return new WaitForSeconds(0.5f);
            first.Hide();
            second.Hide();
            fail.Play();
        }

        first = null;
        second = null;

        if(scoreNum == 5)
        {
            canvas1.gameObject.SetActive(true);
            
        }
    }
}
