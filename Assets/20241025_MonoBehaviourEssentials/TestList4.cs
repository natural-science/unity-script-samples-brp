using System.Collections.Generic;
using UnityEngine;

namespace _20241025_MonoBehaviourEssentials
{
  public class TestList4 : MonoBehaviour
  {
    [SerializeField] private Transform tr0;
    [SerializeField] private Transform tr1;
    private int _numSegments = 16;
    private List<Transform> _trMiddle = new();

    void Start()
    {
      for (int i = 0; i < _numSegments; i++) {
        var go = GameObject.CreatePrimitive(PrimitiveType.Sphere);
        _trMiddle.Add(go.transform);
      }
    }

    void Update()
    {
      for (int i = 0; i < _numSegments; i++) {
        float r = (i + 0.5f) / _numSegments;
        _trMiddle[i].position = tr0.position * r + tr1.position * (1f - r);
      }
    }
  }
}
