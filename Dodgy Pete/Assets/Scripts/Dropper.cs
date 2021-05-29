using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dropper : MonoBehaviour
{

  MeshRenderer renderer;
  Rigidbody rigidbody;
  [SerializeField] float timeToWait = 3f;

  void Start()
  {
    renderer = GetComponent<MeshRenderer>();
    renderer.enabled = false;

    rigidbody = GetComponent<Rigidbody>();
    rigidbody.useGravity = false;
  }

  void Update()
  {
    // Debug.Log(Time.time);
    if (Time.time > timeToWait)
    {
      // Debug.Log("3 seconds has elapsed");
      renderer.enabled = true;
      rigidbody.useGravity = true;

    }
  }
}
