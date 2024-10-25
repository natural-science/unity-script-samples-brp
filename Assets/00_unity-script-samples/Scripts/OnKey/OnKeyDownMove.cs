using UnityEngine;

public class OnKeyDownMove : MonoBehaviour
{
  [SerializeField] private KeyCode m_key_0 = KeyCode.A;
  [SerializeField] private KeyCode m_key_1 = KeyCode.D;
  [SerializeField] private KeyCode m_key_2 = KeyCode.W;
  [SerializeField] private KeyCode m_key_3 = KeyCode.S;
  [SerializeField] Vector3 m_velocity_0 = 5f * Vector3.left;
  [SerializeField] Vector3 m_velocity_1 = 5f * Vector3.right;
  [SerializeField] Vector3 m_velocity_2 = 5f * Vector3.forward;
  [SerializeField] Vector3 m_velocity_3 = 5f * Vector3.back;

  void Update()
  {
    if (Input.GetKey(m_key_0)) {
      transform.position += Time.deltaTime * m_velocity_0;
    }
    if (Input.GetKey(m_key_1)) {
      transform.position += Time.deltaTime * m_velocity_1;
    }
    if (Input.GetKey(m_key_2)) {
      transform.position += Time.deltaTime * m_velocity_2;
    }
    if (Input.GetKey(m_key_3)) {
      transform.position += Time.deltaTime * m_velocity_3;
    }
  }
}
