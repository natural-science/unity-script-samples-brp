using UnityEngine;

namespace _20241025_MonoBehaviourEssentials
{
  public class TestTransform : MonoBehaviour
  {
    void Update()
    {
      Debug.Log($"@@@");
      Debug.Log($"  transform = {transform}");
      Debug.Log($"  parent = {transform.parent}");
      Debug.Log($"  position = {transform.position}");
      Debug.Log($"  localPosition = {transform.localPosition}");
      Debug.Log($"  rotation = {transform.rotation}");
      Debug.Log($"  localRotation = {transform.localRotation}");
      Debug.Log($"  localScale = {transform.localScale}");
    }
  }
}
