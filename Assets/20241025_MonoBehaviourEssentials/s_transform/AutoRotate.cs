using UnityEngine;

namespace _20241025_MonoBehaviourEssentials
{
  public class AutoRotate : MonoBehaviour
  {
    void Update()
    {
      transform.rotation = Quaternion.AngleAxis(1f, new Vector3(0f, 1f, 0f)) * transform.rotation;
    }
  }
}
