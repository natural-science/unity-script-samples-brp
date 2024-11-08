using UnityEngine;

namespace _20241025_MonoBehaviourEssentials
{
  public class TestCreatePrimitive1 : MonoBehaviour
  {
    [SerializeField] private Transform tr0;
    [SerializeField] private Transform tr1;
    private Transform _trMiddle;

    void Start()
    {
      var go = GameObject.CreatePrimitive(PrimitiveType.Sphere);
      _trMiddle = go.transform;
    }

    void Update()
    {
      _trMiddle.position = (tr0.position + tr1.position) / 2;
    }
  }
}
