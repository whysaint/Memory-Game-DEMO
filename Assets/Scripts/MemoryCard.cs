using System;
using UnityEngine;
using UnityEngine.Serialization;

public class MemoryCard : MonoBehaviour
{
    [SerializeField] private GameObject cardBack;
    [SerializeField] private SceneController controller;

    [FormerlySerializedAs("audio")] [SerializeField] private AudioSource cardUp;
    [FormerlySerializedAs("audio")] [SerializeField] private AudioSource cardDown;
    [FormerlySerializedAs("audio")] [SerializeField] private AudioSource twoCardIsCorect;
    [FormerlySerializedAs("audio")] [SerializeField] private AudioSource finishSound;

    private int _id;

    public int Id
    {
        get { return _id; }
    }

    public void SetCard(int id, Sprite image)
    {
        _id = id;
        GetComponent<SpriteRenderer>().sprite = image;
    }
    
    public void OnMouseDown()
    {
        cardUp.Play();
        if (cardBack.activeSelf && controller.canReveal)
        {
            cardBack.SetActive(false);
            controller.CardRevealed(this);
        }
    }

    public void Unreveal()
    {
        cardDown.Play();
        cardBack.SetActive(true);
    }

    public void PLaySound()
    {
        twoCardIsCorect.Play();
    }
    
    public void PLaySoundFinishGame()
    {
        finishSound.Play();
    }
}