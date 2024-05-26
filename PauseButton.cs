using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseButton : MonoBehaviour
{
    private float last = 1;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P) && Time.timeScale == 0){
            Time.timeScale = last;
        } else if (Input.GetKeyDown(KeyCode.P) && Time.timeScale != 0){
            last = Time.timeScale;
            Time.timeScale = 0;
        } else if (Input.GetKeyDown(KeyCode.I)) {
            Time.timeScale /= 2;
        } else if (Input.GetKeyDown(KeyCode.O)) {
            Time.timeScale *= 2;
        } else if (Input.GetKeyDown(KeyCode.U)) {
            Time.timeScale = 1;
        }
    }
}
