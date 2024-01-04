using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheatMode : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Collected"))
        {
            SetCheatMode();
        }
    }

    public static void SetCheatOff(){
        PlayerMovement.CheatMode = false;
        PlayerLife.trap= "Trap";
    }

    public void SetCheatMode(){
        PlayerMovement.CheatMode = true;
        PlayerLife.trap= "deo co tac dung nua";
    }

}
