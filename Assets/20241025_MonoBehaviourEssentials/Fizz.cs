using UnityEngine;

// この講座のルール:
//         ↓↓↓↓↓↓↓↓ はフォルダの日付と合わせる
namespace _20241025_MonoBehaviourEssentials
{
  public class Fizz : MonoBehaviour
  {
    private int i = 0; 

    void Update()
    {
      i++;
      if (i % 3 == 0) {
        Debug.Log("Fizz");
      } else {
        Debug.Log(i);
      }
    }
  }
}
