using UnityEngine;

// この講座のルール:
//         ↓↓↓↓↓↓↓↓ はフォルダの日付と合わせる
namespace _20241025_MonoBehaviourEssentials
{
  public class Hello0 : MonoBehaviour
  {
    private int i = 0; 
    private int j = 0; 

    void Update()
    {
      j += 1;
      Debug.Log(j);
    }
  }
}
