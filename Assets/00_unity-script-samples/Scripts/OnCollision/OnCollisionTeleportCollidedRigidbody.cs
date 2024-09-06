using UnityEngine;

/// <summary>
/// 衝突したリジッドボディを特定の場所にテレポートする。
/// </summary>
public class OnCollisionTeleportCollidedRigidbody : MonoBehaviour
{
  /// <summary>
  /// 衝突したリジッドボディがテレポートされる宛先を表す Transform。
  /// </summary>
  [SerializeField] private Transform m_destination;

  /// <summary>
  /// 衝突したリジッドボディを特定の宛先にテレポートする。
  /// </summary>
  /// <param name="other">/// 衝突の情報を含む Collision オブジェクト。</param>
  private void OnCollisionEnter(Collision other)
  {
    other.rigidbody.position = m_destination.position;
  }
}
