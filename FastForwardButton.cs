using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FastForwardButton : MonoBehaviour
{
    void OnMouseDown() {
        Time.timeScale *= 2;
    }
}
