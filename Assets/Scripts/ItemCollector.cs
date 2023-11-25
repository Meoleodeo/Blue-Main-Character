using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.UI;

public class ItemCollector : MonoBehaviour
{
    public static int cherries = 0;

    [SerializeField] private Text cherriesText;

    [SerializeField] private AudioSource collectionSoundEffect;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Cherry"))
        {
            collectionSoundEffect.Play();
            Destroy(collision.gameObject);
            cherries += 1;
            cherriesText.text = "Cherries: " + cherries;
        }
    }
    public static int GetItemCount()
    {
        return cherries;
    }
}