using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public static int _score = 0;
    public static int _flies = 0;
    public static float speed = 1f;
    public Text _text;
    [SerializeField] private GameObject _fly;
    
    void Update()
    {
        if (_flies == 0)
        {
            var vec = new Vector2(UnityEngine.Random.Range(-FlyBehavior.maxDistance, FlyBehavior.maxDistance), UnityEngine.Random.Range(-FlyBehavior.maxDistance, FlyBehavior.maxDistance) / 2);
            Instantiate(_fly, vec, Quaternion.identity);
            _flies++;
        }
        _text.text = _score.ToString();
    }
}
