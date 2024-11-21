using UnityEngine;

// この講座のルール:
//         ↓↓↓↓↓↓↓↓ はフォルダの日付と合わせる
namespace _20241025_MonoBehaviourEssentials
{
  public class HelloSimple : MonoBehaviour
  {
    void Start()
    {
      Debug.Log("HelloSimple.Start() from " + name);
    }

    void Update()
    {
      Debug.Log("HelloSimple.Update() from " + name);
    }
  }
}