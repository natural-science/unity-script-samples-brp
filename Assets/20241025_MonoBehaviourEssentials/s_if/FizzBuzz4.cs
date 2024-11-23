using UnityEngine;

// この講座のルール:
//         ↓↓↓↓↓↓↓↓ はフォルダの日付と合わせる
namespace _20241025_MonoBehaviourEssentials
{
  public class FizzBuzz4 : MonoBehaviour
  {
    private int i = 0;

    void Update()
    {
      i++;
      var msg =
        i % 15 == 0 ? "Fizz Buzz" :
        i % 3 == 0 ? "Fizz" :
        i % 5 == 0 ? "Buzz" :
        i.ToString();
/*
      // これでも同じ結果
      var msg =
        i % 3 != 0 && i % 5 != 0 ? i.ToString() :
        i % 3 == 0 && i % 5 != 0 ? "Fizz" :
        i % 3 != 0 && i % 5 == 0 ? "Buzz" : "Fizz Buzz";
*/
      Debug.Log(msg);
    }
  }
}
