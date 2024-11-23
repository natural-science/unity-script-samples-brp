using UnityEngine;

// この講座のルール:
//         ↓↓↓↓↓↓↓↓ はフォルダの日付と合わせる
namespace _20241025_MonoBehaviourEssentials.s_Vector3
{
  public class GoCloser3 : MonoBehaviour
  {
    [SerializeField] private GameObject go0;
    [SerializeField] private GameObject go1;
    [SerializeField] private GameObject go2;

    private float _timer;
    private int _targetIndex;

    void Start()
    {
      _timer = 0f;
      _targetIndex = 0;
    }

    void Update()
    {
      _timer -= 0.01f; // フレーム毎に 0.01 秒経過すると仮定する。
      if (_timer <= 0f) {
        _timer += 1f;
        _targetIndex = (_targetIndex + 1) % 3;
      }

      var target = _targetIndex == 0 ? go0 :
                   _targetIndex == 1 ? go1 : go2;
      var diff = target.transform.position - transform.position;
      var dir = diff.normalized;
      transform.position += dir * 0.01f;
    }
  }
}
