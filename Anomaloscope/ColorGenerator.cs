using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//this a class that has functions for the mini-game to process and randomize the color values for a given color slot in the minigame
public class ColorGenerator : MonoBehaviour
{
    //a slot for the GameObject that represents the color that will be manipulated and generated
    [SerializeField] GameObject maniColor;

    //SpriteRenderer 
    SpriteRenderer staticColor;

    //integer variables for the script to manipulate
    int randomGreen,randomRed,randomBlue, randomPick;
    int solveNum;
    float floatGreen,floatRed,floatBlue;
    
    void Start()
    {
        //disables the object first, since if it is active, the game will error out that there's no current manipulated color
        //on start of the script, it will randomize three numbers and apply it as an RGB color value to the Manipulated Color Piece, then set it as active
        maniColor.SetActive(false);
        randomBlue = UnityEngine.Random.Range(2, 8);
        solveNum = randomBlue;
        floatBlue = (float)(System.Convert.ToDouble(randomBlue)*10 / 100);

        randomGreen = UnityEngine.Random.Range(50, 99);
        floatGreen = (float) (System.Convert.ToDouble(randomGreen) / 100);

        randomRed = UnityEngine.Random.Range(50, 80);
        floatRed = (float)(System.Convert.ToDouble(randomRed) / 100);

        randomPick = UnityEngine.Random.Range(0, 100);

        
        staticColor = GetComponent<SpriteRenderer>();
        staticColor.color = new Color(floatRed, floatGreen, floatBlue, 1);
        maniColor.SetActive(true);
    }

    //these functions return the different color components of a certain Manipulated Color
    public float getRed()
    {
        staticColor = GetComponent<SpriteRenderer>();
        return staticColor.color.r;
    }
    public float getGreen()
    {
        staticColor = GetComponent<SpriteRenderer>();
        return staticColor.color.g;
    }
    public float getBlue()
    {
        staticColor = GetComponent<SpriteRenderer>();
        return staticColor.color.b;
    }

    //returns the number needed to solve the puzzle
    public int getSolveNum()
    {
        return solveNum;
    }

}
