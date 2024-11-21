using UnityEngine;

// この講座のルール:
//         ↓↓↓↓↓↓↓↓ はフォルダの日付と合わせる
namespace _20241025_MonoBehaviourEssentials
{
  public class Roundtrip0 : MonoBehaviour
  {
    private int i = 0;

    void Update()
    {
      if (i < 4) {
        Debug.Log(i);
      } else {
        Debug.Log(6 - i);
      }

      i = (i + 1) % 6;
    }
  }
}
