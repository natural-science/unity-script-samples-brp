using UnityEngine;

namespace _20241025_MonoBehaviourEssentials
{
  public class TestSerializeField : MonoBehaviour
  {
    [SerializeField] private int _int0;
    [SerializeField] private float _float0;
    [SerializeField] private string _string0;
    [SerializeField] private Vector3 _vector3_0;
    [SerializeField] private TestSerializeField _component0; // コンポーネントへの参照
    [SerializeField] private GameObject _gameObject0; // GameObject への参照

    void Update()
    {
      Debug.Log($"@@@");
      Debug.Log($"  _int0 = {_int0}");
      Debug.Log($"  _float0 = {_float0}");
      Debug.Log($"  _string0 = {_string0}");
      Debug.Log($"  _vector3_0 = {_vector3_0}");
      Debug.Log($"  _component0 = {_component0}");
      Debug.Log($"  _gameObject0 = {_gameObject0}");
    }
  }
}
