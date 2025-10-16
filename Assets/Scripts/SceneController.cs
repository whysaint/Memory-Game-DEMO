using System;
using UnityEngine;
using Random = UnityEngine.Random;

public class SceneController : MonoBehaviour
{
    [SerializeField] private MemoryCard originalCard;
    [SerializeField] private Sprite[] images;

    private void Start()
    {
        int id = Random.Range(0, images.Length);
        originalCard.SetCard(id, images[id]);
    }
}
