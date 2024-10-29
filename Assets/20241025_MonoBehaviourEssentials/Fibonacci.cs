using UnityEngine;

public class Fibonacci : MonoBehaviour
{
  private int _n0 = 1;
  private int _n1 = 1;

  void Update()
  {
    Debug.Log(_n0);
    var n2 = _n0 + _n1;
    _n0 = _n1;
    _n1 = n2;
  }
}
