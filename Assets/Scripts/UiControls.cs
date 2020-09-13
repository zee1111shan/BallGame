using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UiControls : MonoBehaviour
{

    public static bool UiButtonTriggred=false;
    public static bool jump=false;

    public void jumpBtn()
    {
        UiButtonTriggred = true;
        jump = true;
        //Debug.Log("Ui triggred");
    }
}
