using UnityEngine;

// この講座のルール:
//         ↓↓↓↓↓↓↓↓ はフォルダの日付と合わせる
namespace _20241025_MonoBehaviourEssentials
{
  public class FizzBuzz1 : MonoBehaviour
  {
    private int i = 0;

    void Update()
    {
      i++;
      if (i % 3 == 0 && i % 5 != 0) {
        Debug.Log("Fizz");
      } else if (i % 3 != 0 && i % 5 == 0) {
        Debug.Log("Buzz");
      } else if (i % 3 == 0 && i % 5 == 0) {
        Debug.Log("Fizz Buzz");
      } else {
        Debug.Log(i);
      }
    }
  }
}
