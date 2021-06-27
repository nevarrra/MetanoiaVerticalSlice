﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Receptionist : MonoBehaviour
{
    public SpeechManager narrations;
    public GameObject player;
    private bool hasExecuted;
    // Start is called before the first frame update
    void Start()
    {
        hasExecuted = false;
    }

    public void GoThoughSpeeches()
    {
        if (Vector3.Distance(player.transform.position, gameObject.transform.position) <= 10f && !hasExecuted)
        {
            narrations.TriggeredSpeech(gameObject, 0);
            hasExecuted = true;
        }

        if (Vector3.Distance(player.transform.position, gameObject.transform.position) >= 20f && narrations.IsSentenceEnded(gameObject))
        {
            hasExecuted = false;
        }
    }

    // Update is called once per frame
    void Update()
    {
        GoThoughSpeeches();
    }
}
