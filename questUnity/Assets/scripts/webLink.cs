using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class webLink : MonoBehaviour
{
    public string Url;

    public void Open(){
        Application.OpenURL(Url);
    }


}
