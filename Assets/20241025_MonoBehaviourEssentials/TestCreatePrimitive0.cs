using UnityEngine;

namespace _20241025_MonoBehaviourEssentials
{
  public class TestCreatePrimitive0 : MonoBehaviour
  {
    void Start()
    {
      {
        var go = GameObject.CreatePrimitive(PrimitiveType.Cube);
        go.transform.position = new Vector3(0f, 0.5f, 0f);
      }
      {
        var go = GameObject.CreatePrimitive(PrimitiveType.Sphere);
        go.transform.position = new Vector3(0f, 1.5f, 0f);
      }
      {
        var go = GameObject.CreatePrimitive(PrimitiveType.Sphere);
        go.transform.position = new Vector3(-0.16f, 1.5f, -0.45f);
        go.transform.localScale = new Vector3(0.2f, 0.2f, 0.2f);
      }
      {
        var go = GameObject.CreatePrimitive(PrimitiveType.Sphere);
        go.transform.position = new Vector3(0.16f, 1.5f, -0.45f);
        go.transform.localScale = new Vector3(0.2f, 0.2f, 0.2f);
      }
    }
  }
}
