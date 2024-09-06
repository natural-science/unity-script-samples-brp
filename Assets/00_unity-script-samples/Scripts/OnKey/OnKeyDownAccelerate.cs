using UnityEngine;

/// <summary>
/// This script is responsible for accelerating a game object when specific keys are pressed.
/// The acceleration is applied to the game object's Rigidbody component.
/// </summary>
public class OnKeyDownAccelerate : MonoBehaviour
{
  [SerializeField] private KeyCode m_key_0 = KeyCode.A;
  [SerializeField] private KeyCode m_key_1 = KeyCode.D;
  [SerializeField] private KeyCode m_key_2 = KeyCode.W;
  [SerializeField] private KeyCode m_key_3 = KeyCode.S;
  [SerializeField] Vector3 m_acceleration_0 = Vector3.left;
  [SerializeField] Vector3 m_acceleration_1 = Vector3.right;
  [SerializeField] Vector3 m_acceleration_2 = Vector3.forward;
  [SerializeField] Vector3 m_acceleration_3 = Vector3.back;

  void Update()
  {
    if (Input.GetKey(m_key_0)) {
      var rb = GetComponent<Rigidbody>();
      rb.AddForce(m_acceleration_0, ForceMode.Acceleration);
    }
    if (Input.GetKey(m_key_1)) {
      var rb = GetComponent<Rigidbody>();
      rb.AddForce(m_acceleration_1, ForceMode.Acceleration);
    }
    if (Input.GetKey(m_key_2)) {
      var rb = GetComponent<Rigidbody>();
      rb.AddForce(m_acceleration_2, ForceMode.Acceleration);
    }
    if (Input.GetKey(m_key_3)) {
      var rb = GetComponent<Rigidbody>();
      rb.AddForce(m_acceleration_3, ForceMode.Acceleration);
    }
  }
}
