using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UI_controller : MonoBehaviour
{
    [SerializeField] private byte _sceneToLoad;
    public void ChangeScene()
    {
        SceneManager.LoadScene(_sceneToLoad);
    }
}
