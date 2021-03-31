using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{

    public double x;
    public double y;
    public double speedx = 0.02;
    public double speedy = 0.03;

    public void SetXY(double xx, double yy)
    {
      x = xx;
      y = yy;
    }

    public void SetSpeed(double speedxx, double speedyy)
    {
      speedx = speedxx;
      speedy = speedyy;
    }

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
      transform.position = new Vector2((float)System.Math.Sin(x), (float)System.Math.Sin(y));
      x += speedx;
      y += speedy;
    }
}
