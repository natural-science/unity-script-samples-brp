using UnityEngine;

// この講座のルール:
//         ↓↓↓↓↓↓↓↓ はフォルダの日付と合わせる
namespace _20241025_MonoBehaviourEssentials
{
  public class FizzBuzz2 : MonoBehaviour
  {
    private int i = 0; 

    void Update()
    {
      i++;
/*
      var msg =
        i % 3 != 0 && i % 5 != 0 ? i.ToString() :
        i % 3 == 0 && i % 5 != 0 ? "Fizz" :
        i % 3 != 0 && i % 5 == 0 ? "Buzz" : "Fizz Buzz";
*/
      var msg =
        i % 15 == 0 ? "Fizz Buzz" :
        i % 3 == 0 ? "Fizz" :
        i % 5 == 0 ? "Buzz" :
        i.ToString();
      Debug.Log(msg);

/*
      if (i % 3 != 0 && i % 5 != 0) {
        Debug.Log(i);
      } else if (i % 3 == 0 && i % 5 != 0) {
        Debug.Log("Fizz");
      } else if (i % 3 != 0 && i % 5 == 0) {
        Debug.Log("Buzz");
      } else {
        Debug.Log("FizzBuzz");
      }
*/
    }
  }
}
