using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
namespace ItemCollectorNameSpace
{
        public class ItemCollector : MonoBehaviour
    {
        public int cherries = 0;

        [SerializeField] private Text cherriesText;

        [SerializeField] private AudioSource collectionSoundEffect;

        public void OnTriggerEnter2D(Collider2D collision) {
            if (collision.gameObject.CompareTag("Cherry"))
            {
                collectionSoundEffect.Play();
                Destroy(collision.gameObject);
                cherries += 1;
                cherriesText.text = "Cherries: " + cherries;
            }
        }
    }
}

