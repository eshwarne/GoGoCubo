using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndAll : MonoBehaviour
{
    // Start is called before the first frame update
    public void clickButton()
    {
        Debug.Log("Application Quitting");
        Application.Quit();
    }
}

