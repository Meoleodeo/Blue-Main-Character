using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

using ItemCollectorNameSpace;


public class Finish : MonoBehaviour
{
    private AudioSource finishSound;

    [SerializeField] private int cherriesEnough;
    private int cherries = 0;
    private bool levelCompleted = false;

    private void Start()
    {
        finishSound = GetComponent<AudioSource>();        
    }
    private void OnTriggerEnter2D(Collider2D collision) {
        if (collision.gameObject.name == "Player" && !levelCompleted)
        {
            finishSound.Play();
            levelCompleted = true;
            if (cherries == cherriesEnough)
            {
            Invoke("CompleteLevel", 2f);
            }
        }
    }

    private void CompleteLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
