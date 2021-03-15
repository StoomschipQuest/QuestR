using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameLoader : MonoBehaviour
{

    public void loadGame()
    {
        Application.LoadLevel("gameAI");
    }

    public void loadMainMenu()
    {
        Application.LoadLevel("mainMenu");
    }

    public GameObject target;

    public void deleteObject()
    {
        Destroy(GameObject.Find("m_TrackedImagePrefab"));
    }
}
