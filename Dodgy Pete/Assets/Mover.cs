using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
  [SerializeField] float xValue = 0.01f;
  [SerializeField] float yValue = 0.03f;
  [SerializeField] float zValue = 0.01f;


  // Start is called before the first frame update
  void Start()
  {
    // we access the transform of the object and the method Translate and define where it should go as (x,y,z). Add 1, add 0, add 0
  }


  // Update is called once per frame
  void Update()
  {

    transform.Translate(xValue, yValue, zValue);
  }
}
