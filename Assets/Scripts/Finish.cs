using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Finish : MonoBehaviour
{
    private AudioSource finishSound;

    [SerializeField] public int cherriesEnough;
    [SerializeField] private Text notification;
    private bool levelCompleted = false;
    private ItemCollector itemCollector;


    private void Start()
    {
        finishSound = GetComponent<AudioSource>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Player")
        {
            finishSound.Play();
            if (ItemCollector.GetItemCount() >= cherriesEnough)
            {
                Invoke("CompleteLevel", 2f);
            }
            else
            {
                notification.text = "not enough cherries";
                notification.gameObject.SetActive(true);
                Invoke("HideMessage", 2f);
            }

        }
    }

    private void CompleteLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    private void HideMessage()
    {
        if (notification != null)
        {
            notification.gameObject.SetActive(false);
        }
    }
}
