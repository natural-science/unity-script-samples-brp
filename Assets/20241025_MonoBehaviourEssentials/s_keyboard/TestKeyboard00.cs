using UnityEngine;
using UnityEngine.InputSystem;

// この講座のルール:
//         ↓↓↓↓↓↓↓↓ はフォルダの日付と合わせる
namespace _20241025_MonoBehaviourEssentials.s_keyboard
{
  public class TestKeyboard00 : MonoBehaviour
  {
    [SerializeField] private Transform _t0;
    [SerializeField] private Transform _t1;
    [SerializeField] private Transform _t2;
    private int _targetIndex = 0;

    void Update()
    {
      var targetPosition =
        _targetIndex == 0 ? _t0.position :
        _targetIndex == 1 ? _t1.position : _t2.position;
      var diff = targetPosition - transform.position;
      transform.position += diff.normalized * 5.0f * Time.deltaTime;
      
      if ((targetPosition - transform.position).sqrMagnitude < 1f) {
        _targetIndex = (_targetIndex + 1) % 3;
      }
    }
  }
}
