using UnityEngine;

// この講座のルール:
//         ↓↓↓↓↓↓↓↓ はフォルダの日付と合わせる
namespace _20241025_MonoBehaviourEssentials.s_Vector3
{
  public class MoveToCenter2 : MonoBehaviour
  {
    [SerializeField] private GameObject go0;
    [SerializeField] private GameObject go1;

    void Update()
    {
      transform.position = (go0.transform.position + go1.transform.position) / 2.0f;
    }
  }
}
