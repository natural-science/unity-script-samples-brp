using UnityEngine;

public class ChaseTargetByAccelerating : MonoBehaviour
{
    [SerializeField] private Transform m_target;
    [SerializeField] private float m_acceleration;

    void FixedUpdate()
    {
        Vector3 direction = (m_target.position - transform.position).normalized;
        var rb = GetComponentInChildren<Rigidbody>();
        rb.AddForce(direction * m_acceleration);
    }
}
