using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class General : MonoBehaviour
{

  private int cnt = 0;
  private double speedx = 0.02;
  private double speedy = 0.03;
  private float r = 1.0f;
  private float g = 1.0f;
  private float b = 1.0f;
  private float a = 0.4f;

  // Start is called before the first frame update
  void Start()
  {
    Debug.Log("General.Start");
  }

  // Update is called once per frame
  void Update()
  {
    if (cnt++ < 100) {
      Color color = new Color(r,g,b,a);
      r -= 0.02f;
      g -= 0.03f;
      b -= 0.04f;
      GameObject go = GameObject.Find("Hexagon");
      GameObject newgo = GameObject.Instantiate(go);
      newgo.GetComponent<Movement>().SetXY(0, 0);
      newgo.GetComponent<Movement>().SetSpeed(speedx, speedy);
      newgo.GetComponent<Renderer>().material.color = color;
      speedx += 0.0001;
      speedy += 0.0001;
    }
  }
}
