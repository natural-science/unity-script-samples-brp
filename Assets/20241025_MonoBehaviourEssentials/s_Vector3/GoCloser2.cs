using UnityEngine;

// この講座のルール:
//         ↓↓↓↓↓↓↓↓ はフォルダの日付と合わせる
namespace _20241025_MonoBehaviourEssentials.s_Vector3
{
  public class GoCloser2 : MonoBehaviour
  {
    [SerializeField] private GameObject go0;
    [SerializeField] private GameObject go1;

    private float _timer;
    private bool _goingToGo0;

    void Start()
    {
      _timer = 0f;
      _goingToGo0 = true;
    }

    void Update()
    {
      _timer -= 0.005f; // フレーム毎に 0.005 秒経過すると仮定する。
      if (_timer <= 0f) {
        _timer += 1f;
        _goingToGo0 = !_goingToGo0;
      }

      var target = _goingToGo0 ? go0 : go1;
      var diff = target.transform.position - transform.position;
      var dir = diff.normalized;
      transform.position += dir * 0.01f;
    }
  }
}
