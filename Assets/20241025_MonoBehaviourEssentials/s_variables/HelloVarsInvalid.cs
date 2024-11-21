using UnityEngine;

namespace _20241025_MonoBehaviourEssentials
{
  public class HelloVarsInvalid : MonoBehaviour
  {
    public int a = 99;
    public int b = 88;

    void Start()
    {
#if false
      Debug.Log($"A: {a}, {b}");
      {
        Debug.Log($"B: {a}, {b}"); // C# ではだめ
        a = 9999; // C# ではだめ
        Debug.Log($"C: {a}, {b}"); // C# ではだめ
        int a = 11; // C# ではだめ
        int b = 22; // C# ではだめ
        Debug.Log($"D: {a}, {b}");
        {
          int a = 33; // C# ではだめ
          Debug.Log($"E: {a}, {b}");
          {
            a = 333;
            int b = 44; // C# ではだめ
            Debug.Log($"F: {a}, {b}");
          }
          a = 3333;
          Debug.Log($"G: {a}, {b}");
        }
        {
          int b = 55; // C# ではだめ
          Debug.Log($"H: {a}, {b}");
        }
        Debug.Log($"I: {a}, {b}");
      }
      Debug.Log($"J: {a}, {b}");
#endif
    }
  }
}
