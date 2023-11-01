using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SeenController : MonoBehaviour
{
    public void SwitchScenes(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
}
