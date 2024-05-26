using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyBehavior : MonoBehaviour
{
    [SerializeField] private GameObject _self;
    public static float speed;
    public static float range;
    public static float maxDistance;
    public bool spawn = true;
    Vector2 wayPoint;
    void Start()
    {
        SetNewDestination();
    }

    void Update()
    {
        if (spawn)
        {
            SetNewDestination();
            spawn = false;
        }
        transform.position = Vector2.MoveTowards(transform.position, wayPoint, speed * Time.deltaTime);
        if(Vector2.Distance(transform.position, wayPoint) <= range)
        {
            SetNewDestination();
        }
    }
    
    void SetNewDestination()
    {
        wayPoint = new Vector2(UnityEngine.Random.Range(-maxDistance, maxDistance), UnityEngine.Random.Range(-maxDistance, maxDistance) / 2);
    }

    void OnMouseDown()
    {
        Score._score++;
        Destroy(_self);
        Score._flies--;
    }
}
