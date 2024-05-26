using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlowDownButton : MonoBehaviour
{
    void OnMouseDown() {
        Time.timeScale /= 2;
    }
}
