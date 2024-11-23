using UnityEngine;

// この講座のルール:
//         ↓↓↓↓↓↓↓↓ はフォルダの日付と合わせる
namespace _20241025_MonoBehaviourEssentials.s_Vector3
{
  public class WayPoint3 : MonoBehaviour
  {
    [SerializeField] private GameObject go0;
    [SerializeField] private GameObject go1;
    [SerializeField] private GameObject go2;

    private int _targetIndex;

    void Start()
    {
      _targetIndex = 0;
    }

    void Update()
    {
      var target = _targetIndex == 0 ? go0 :
                   _targetIndex == 1 ? go1 : go2;
      var diff = target.transform.position - transform.position;

      if (diff.magnitude < 1.5f) {
        _targetIndex = (_targetIndex + 1) % 3;
      }

      var dir = diff.normalized;
      transform.position += dir * 0.01f;
    }
  }
}
