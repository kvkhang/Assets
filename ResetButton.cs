using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetButton : MonoBehaviour
{
    void OnMouseDown(){
        Time.timeScale = 1;
        TimeDisplay.minutes = 0;
        TimeDisplay.hours = 0;
        TimeDisplay.time = 0;
    }
}
