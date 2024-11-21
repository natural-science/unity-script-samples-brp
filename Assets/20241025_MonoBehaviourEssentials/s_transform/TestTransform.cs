using UnityEngine;

namespace _20241025_MonoBehaviourEssentials
{
  public class TestTransform : MonoBehaviour
  {
    [SerializeField] private GameObject _go0;
    [SerializeField] private GameObject _go1;
    [SerializeField] private GameObject _go2;

    private float timer = 0f;
    private int target = 0;

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


      timer -= 0.01f;
      if (timer < 0f) {
        timer = 1f;
        target = (target + 1) % 3;
      }

      if (target == 0) {
        transform.position += (_go0.transform.position - transform.position) * 0.01f;
      } else if (target == 1) {
        transform.position += (_go1.transform.position - transform.position) * 0.01f;
      } else {
        transform.position += (_go2.transform.position - transform.position) * 0.01f;
      }
    }
  }
}
