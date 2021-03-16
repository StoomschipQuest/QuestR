using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameLoader : MonoBehaviour
{

    public void loadGame()
    {
        Application.LoadLevel("gameAI");
    }

    public void loadBadgeMenu()
    {
        Application.LoadLevel("badgeMenu");
    }
}
