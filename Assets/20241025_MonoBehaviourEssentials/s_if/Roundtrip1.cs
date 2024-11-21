using UnityEngine;

// この講座のルール:
//         ↓↓↓↓↓↓↓↓ はフォルダの日付と合わせる
namespace _20241025_MonoBehaviourEssentials
{
  public class Roundtrip1 : MonoBehaviour
  {
    private bool rising = true;
    private int i = 0;

    void Update()
    {
      Debug.Log(i);

      if (rising) {
        i++;
        if (i >= 3) {
          rising = false;
        }
      } else {
        i--;
        if (i <= 0) {
          rising = true;
        }
      }
    }
  }
}
