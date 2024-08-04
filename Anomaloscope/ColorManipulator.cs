using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//this a class that has functions for the actual manipulation of colors and functions checking for the win condition of the game that the ColorMaster script uses
public class ColorManipulator : MonoBehaviour
{
    //serialized fields for the GameObjects used for this script
    [SerializeField] private GameObject staticSquare;
    [SerializeField] private Text  text2, currentText;
    [SerializeField] private GameObject leftChange;
    [SerializeField] private GameObject rightChange;
    private float currentBlue, red, green, blueGoal;
    private int randomBlue;
    private SpriteRenderer manipulateColor;
    private int answer;
   
    void Start()
    {

        //on start, it initializes and randomizes the actual manipulated color segment that the player will use and initalizes the text hints. 
        randomBlue = UnityEngine.Random.Range(2, 8);
        currentBlue = (float)(System.Convert.ToDouble(randomBlue)*10 / 100);

        
        
        if (red == 1 && green == 1 && blueGoal == 1)
        {
            RedChecker();
        }
        else
        {
            GrabColors();
            RedChecker();
        }
            

        manipulateColor = GetComponent<SpriteRenderer>();
        manipulateColor.color = new Color(red, green, currentBlue, 1);



        text2.text = "Goal Number: " + answer;
        currentText.text = "" + randomBlue;
    }

    //grabs colors for the use of the program using the ColorGenerator functions
    void GrabColors()
    {
        answer = staticSquare.GetComponent<ColorGenerator>().getSolveNum();
        red = staticSquare.GetComponent<ColorGenerator>().getRed();
        green = staticSquare.GetComponent<ColorGenerator>().getGreen();
        blueGoal = staticSquare.GetComponent<ColorGenerator>().getBlue();
    }

    //checks if the answer and randomly generated number is the same, if it is, randomizes the starting number again
    void RedChecker()
    {
        while (answer == randomBlue)
        {
            randomBlue  = UnityEngine.Random.Range(2, 8);
            currentBlue = (float)(System.Convert.ToDouble(randomBlue)*10 / 100);
        }
    }

    //button functions that allow the manipulation of the color value
    public void LeftChanger()
    {
        rightChange.SetActive(true);
        randomBlue -= 1;
        if (randomBlue < 1)
        {
            randomBlue = 1;
            leftChange.SetActive(false);
        }
        currentBlue = (float)(System.Convert.ToDouble(randomBlue) * 10 / 100);
        manipulateColor.color = new Color(red, green, currentBlue, 1);
        currentText.text = "" + randomBlue;
    }

    public void RightChanger()
    {
        leftChange.SetActive(true);
        randomBlue += 1;
        if (randomBlue > 9)
        {
            randomBlue = 9;
            rightChange.SetActive(false);
        }
        currentBlue = (float)(System.Convert.ToDouble(randomBlue) * 10 / 100);
        manipulateColor.color = new Color(red, green, currentBlue, 1);
        currentText.text = "" + randomBlue;
    }


    //returns the current manipulated value
    public float getCurrentBlue()
    {
        float currentBlueGet = currentBlue;
        return currentBlueGet;
    }
}
