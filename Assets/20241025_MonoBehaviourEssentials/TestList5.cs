using System.Collections.Generic;
using UnityEngine;

namespace _20241025_MonoBehaviourEssentials
{
  public class TestList5 : MonoBehaviour
  {
    [SerializeField] private Transform trHead;
    private int _numSegments = 16;
    private List<Transform> _trTail = new();

    void Start()
    {
      _trTail.Add(trHead);

      for (int i = 1; i < _numSegments; i++) {
        var go = GameObject.CreatePrimitive(PrimitiveType.Sphere);
        _trTail.Add(go.transform);
      }
    }

    void Update()
    {
      for (int i0 = 0; i0 < _numSegments - 1; i0++) {
        var i1 = i0 + 1;
        var diff = _trTail[i0].position -_trTail[i1].position;
        var length = diff.magnitude;
        if (length <= 1f)
          continue;
        _trTail[i1].position += diff - diff.normalized;
      }
    }
  }
}
