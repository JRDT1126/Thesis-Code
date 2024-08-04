using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//a class that gives the functions needed for the Card GameObject
public class Card : MonoBehaviour
{
    [SerializeField] private GameObject CardCover;
    [SerializeField] private CardPairingControl control;
    [SerializeField] public string type;
    [SerializeField] public AudioSource audioSource;


    //when a card is clicked, the card is revealed, unless there's another card that is revealed already
    //if so, the function calls another function to check if the two cards is a pair
    public void OnMouseDown()
    {
        if (CardCover.activeSelf && control.pairCheckCondition)
        {
            CardCover.SetActive(false);
            control.cardRevealed(this);
            audioSource.Play();
        }
    }

    //returns the ID of the GameObject
    private int currentId;
    public int getID()
    {
        return currentId;
    }
    
    //changes the sprite of the GameObject, used when refreshing the game or when the game is launched
    public void ChangeSprite(int id, Sprite image,string newType)
    {
        currentId = id;
        type = newType;
        GetComponent<SpriteRenderer>().sprite = image;
    }

    public void Hide()
    {
        CardCover.SetActive(true);
    }
}
