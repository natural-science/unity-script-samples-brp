using UnityEngine;

// この講座のルール:
//         ↓↓↓↓↓↓↓↓ はフォルダの日付と合わせる
namespace _20241025_MonoBehaviourEssentials
{
  public class Hello0136 : MonoBehaviour
  {
    private int i = 0; 
    private int j = 0; 

    void Update()
    {
      Debug.Log(j);
      i++;
      j += i;
    }
  }
}
