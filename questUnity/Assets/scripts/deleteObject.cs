using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class deleteObject : MonoBehaviour
{
    //public GameObject target;

    void Update () 
    {

        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = GetComponent<Camera>().ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
                if (Physics.Raycast(ray, out hit))
                {
                    Debug.Log(target);

                    target = hit.collider.gameObject;
                }
        }

    }

    public GameObject target;

    public void objectDelete()
    {
        if(target != null)
        {
            Destroy(target);
        }
    }

}
