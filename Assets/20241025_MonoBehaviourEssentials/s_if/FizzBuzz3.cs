using UnityEngine;

// この講座のルール:
//         ↓↓↓↓↓↓↓↓ はフォルダの日付と合わせる
namespace _20241025_MonoBehaviourEssentials
{
  public class FizzBuzz3 : MonoBehaviour
  {
    private int i = 0;

    void Update()
    {
      i++;
      if (i % 15 == 0) {
        Debug.Log("Fizz Buzz");
      } else {
        var a = i % 3 + i % 5 == 0;
        if (i % 3 == 0) {
          Debug.Log("Fizz");
        } else {
          if (i % 5 == 0) {
            Debug.Log("Buzz");
          } else {
            Debug.Log(i);
          }
        }
      }
    }
  }
}
