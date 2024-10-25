using UnityEngine;

public class LookAt : MonoBehaviour
{
  [SerializeField] Transform target;

  void Update()
  {
    var direction = target.position - transform.position;
    transform.rotation = Quaternion.LookRotation(direction, Vector3.up);
  }
}
