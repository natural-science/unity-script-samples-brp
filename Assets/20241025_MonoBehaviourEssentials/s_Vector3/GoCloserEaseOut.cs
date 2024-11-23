using UnityEngine;

// この講座のルール:
//         ↓↓↓↓↓↓↓↓ はフォルダの日付と合わせる
namespace _20241025_MonoBehaviourEssentials.s_Vector3
{
  public class GoCloserEaseOut : MonoBehaviour
  {
    [SerializeField] private GameObject go0;

    void Update()
    {
      var diff = go0.transform.position - transform.position;
      transform.position += diff * 0.001f;
    }
  }
}
