using UnityEngine;

namespace _20241025_MonoBehaviourEssentials
{
  public class HelloLocalVars : MonoBehaviour
  {
    private int a = 1;
    private int b = 2;

    void Start()
    {
      Debug.Log($"A: {a}, {b}");
      {
        Debug.Log($"B: {a}, {b}");
        {
          a = 5;
          Debug.Log($"C: {a}, {b}");
          {
            a = 6;
            int b = 7;
            Debug.Log($"D: {a}, {b}");
          }
          a = 8;
          Debug.Log($"E: {a}, {b}");
        }
        {
          int b = 9;
          Debug.Log($"F: {a}, {b}");
        }
        Debug.Log($"G: {a}, {b}");
      }
      Debug.Log($"H: {a}, {b}");
    }
  }
}
