using UnityEngine;

// この講座のルール:
//         ↓↓↓↓↓↓↓↓ はフォルダの日付と合わせる
namespace _20241025_MonoBehaviourEssentials.s_Vector3
{
  public class TrackObject : MonoBehaviour
  {
    [SerializeField] private GameObject target;

    void Update()
    {
      transform.position = target.position;
    }
  }
}
