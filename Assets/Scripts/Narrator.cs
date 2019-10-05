using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Narrator : MonoBehaviour
{
  public string[] messages;
  private Nullable<int> currentMessageIndex;
  private int nextMessageIndex;
  private float lastMessageStartedAt;
  private float lastMessageEndedAt;

  void Start()
  {
    lastMessageEndedAt = Time.time;
  }

  // Update is called once per frame
  void Update()
  {
    if (currentMessageIndex == null)
    {
      if (Time.time > lastMessageEndedAt + 5)
      {
        lastMessageStartedAt = Time.time;

        GetComponent<Text>().text = messages[nextMessageIndex];
        currentMessageIndex = nextMessageIndex;

        nextMessageIndex = (nextMessageIndex + 1) % messages.Length;
      }
    }
    else if (Time.time > lastMessageStartedAt + 10 && Input.GetMouseButtonDown(0))
    {
      GetComponent<Text>().text = "";
      currentMessageIndex = null;
      lastMessageEndedAt = Time.time;
    }
  }
}
