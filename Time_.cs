using UnityEngine;
using UnityEngine.UI; // Add this line to import the Text class

public class TimeDisplay : MonoBehaviour
{
    [SerializeField] private Text _text;
    public static int minutes = 0;
    public static int hours = 0;
    public static float time = 0;

    void FixedUpdate()
    {
        time += Time.deltaTime;
        if (time >= 60) {
            time -= 60;
            minutes++;
            if (minutes >= 60) {
                minutes -= 60;
                hours++;
            }
        }

        // Convert integers and float to strings before concatenation
        if (hours >= 1){
            _text.text = hours + ":" + minutes.ToString("00") + ":" + time.ToString("00.00");
        } else if (minutes >= 1) {
            _text.text = minutes + ":" + time.ToString("00.00");
        } else {
            _text.text = time.ToString("F2");
        }
    }
}
