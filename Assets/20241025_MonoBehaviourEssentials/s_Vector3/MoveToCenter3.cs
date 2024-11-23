using UnityEngine;

// この講座のルール:
//         ↓↓↓↓↓↓↓↓ はフォルダの日付と合わせる
namespace _20241025_MonoBehaviourEssentials.s_Vector3
{
  public class MoveToCenter3 : MonoBehaviour
  {
    [SerializeField] private GameObject go0;
    [SerializeField] private GameObject go1;
    [SerializeField] private GameObject go2;

    void Update()
    {
      transform.position = (go0.transform.position + go1.transform.position + go2.transform.position) / 3.0f;
    }
  }
}
