using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour
{
    public List<List<Event>> EventsList;

    private void Awake()
    {
        EventsList = new List<List<Event>>();
        EventsList[0].Add(new Tornado());
    }

    private void Update()
    {
        
    }
}
