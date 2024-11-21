using UnityEngine;

namespace _20241025_MonoBehaviourEssentials
{
  public class OperatorsMedium : MonoBehaviour
  {
    void Start()
    {
      int a = 0;
      int b = 0;
      Debug.Log($"A: {a}, {b}");
      b = a++;
      Debug.Log($"B: {a}, {b}");
      b = ++a;
      Debug.Log($"C: {a}, {b}");
      a = b = 3;
      Debug.Log($"D: {a}, {b}");

      Debug.Log($"E: {false && true || false} {true && true || false}");
      Debug.Log($"F: {false || true && false} {true || true && false}");
      Debug.Log($"G: {false || true && !false} {!true || true && false}");
      Debug.Log($"H: {!!!!false} {!!!!true}");
      a = 2;
      var s =
        a == 0 ? "zero" :
        a == 1 ? "one" :
        a == 2 ? "two" :
        a == 3 ? "three" : "many";
      Debug.Log($"I: {s}");
    }
  }
}
