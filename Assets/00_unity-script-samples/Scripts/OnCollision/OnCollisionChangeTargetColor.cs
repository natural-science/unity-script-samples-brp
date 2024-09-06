using UnityEngine;

/// <summary>
/// このオブジェクトが別のオブジェクトと衝突したときに、指定されたターゲットオブジェクトの色を変更する。
/// </summary>
public class OnCollisionChangeTargetColor : MonoBehaviour
{
  /// <summary>
  /// ターゲットオブジェクトのレンダラーコンポーネント。
  /// </summary>
  [SerializeField] private Renderer m_targetRenderer;

  /// <summary>
  /// 衝突したときにターゲットオブジェクトの色を変更する色。
  /// </summary>
  [SerializeField] private Color m_color;

  /// <summary>
  /// このオブジェクトが別のオブジェクトと衝突したときに、指定されたターゲットオブジェクトの色を変更する。
  /// </summary>
  private void OnCollisionEnter(Collision other)
  {
    m_targetRenderer.material.color = m_color;
  }
}
