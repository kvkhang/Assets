using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayPauseButton : MonoBehaviour
{
    [SerializeField] private GameObject _play;
    [SerializeField] private GameObject _pause;
    private float last = 1;
    void OnMouseDown() {
        if (Time.timeScale == 0){
            Time.timeScale = last;
            _play.SetActive(true);
            _pause.SetActive(false);
        } 
        else
        {
            last = Time.timeScale;
            Time.timeScale = 0;
            _play.SetActive(false);
            _pause.SetActive(true);
        }
    }
}
