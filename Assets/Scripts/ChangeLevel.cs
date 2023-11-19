using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeLevel : MonoBehaviour
{
    [SerializeField] private string SceneName;
    public void ChangeScene()
    {
        SceneManager.LoadScene(SceneName);
    }
}
