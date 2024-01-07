using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HelpMenu : MonoBehaviour
{
    public Image helpImage;

    public KeyCode helpMenuToggle = KeyCode.Q;

    void Update()
    {
        if (Input.GetKeyDown(helpMenuToggle))
        {
            if (helpImage.enabled == true)
                helpImage.enabled = false;
            else
                helpImage.enabled = true;
        }
    }
}
