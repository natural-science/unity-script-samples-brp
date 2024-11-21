using UnityEngine;

namespace _20241025_MonoBehaviourEssentials
{
  public class OperatorsEasy : MonoBehaviour
  {
    void Start()
    {
      int a = 0;
      int b = 0;
      Debug.Log($"A: {a}, {b}");
      b = a + 1;
      Debug.Log($"B: {a}, {b}");
      a = a + 1;
      Debug.Log($"C: {a}, {b}");
      a += b;
      Debug.Log($"D: {a}, {b}");
      b -= a;
      Debug.Log($"E: {a}, {b}");
      a++;
      Debug.Log($"F: {a}, {b}");
      --b;
      Debug.Log($"G: {a}, {b}");

      Debug.Log($"%: {0 % 3}, {1 % 3}, {2 % 3}, {3 % 3}, {4 % 3}, {5 % 3}, {6 % 3}, {7 % 3}");
      Debug.Log($"==: {0 == 3}, {1 == 3}, {2 == 3}, {3 == 3}, {4 == 3}, {5 == 3}");
      Debug.Log($"!=: {0 != 3}, {1 != 3}, {2 != 3}, {3 != 3}, {4 != 3}, {5 != 3}");
      Debug.Log($"<: {0 < 3}, {1 < 3}, {2 < 3}, {3 < 3}, {4 < 3}, {5 < 3}");
      Debug.Log($"<=: {0 <= 3}, {1 <= 3}, {2 <= 3}, {3 <= 3}, {4 <= 3}, {5 <= 3}");
      Debug.Log($"&&: {false && false}, {false && true}, {true && false}, {true && true}");
      Debug.Log($"||: {false || false}, {false || true}, {true || false}, {true || true}");
      Debug.Log($"!: {!false}, {!true}");
      Debug.Log($"?:: {(true ? 1 : 0)} {(false ? 1 : 0)}");
    }
  }
}
