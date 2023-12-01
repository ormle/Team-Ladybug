using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VbRed : MonoBehaviour
{
    public GameObject bug;

    void Start()
    {
        int bugVisibility = PlayerPrefs.GetInt("Lady", 0);

        if (bugVisibility > 0)
        {
            // Set bug visibility to true
            bug.SetActive(true);
        }
        else
        {
            // Set bug visibility to false
            bug.SetActive(false);
        }
    }
}
