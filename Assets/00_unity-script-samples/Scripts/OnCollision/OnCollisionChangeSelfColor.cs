using UnityEngine;

/// <summary>
/// 他のオブジェクトと衝突したときに、ゲームオブジェクトとその子のレンダラーのマテリアルの色を変更する。
/// </summary>
public class OnCollisionChangeSelfColor : MonoBehaviour
{
  /// <summary>
  /// /// 衝突した後のレンダラーのマテリアルの色。
  /// </summary>
  [SerializeField] private Color m_color;

  /// <summary>
  /// ゲームオブジェクトが別のオブジェクトと衝突したときに呼び出される。
  /// </summary>
  private void OnCollisionEnter(Collision other)
  {
    // ゲームオブジェクトとその子のレンダラーをすべてループし、処理する。
    foreach (var r in GetComponentsInChildren<Renderer>()) {
      // /// レンダラーのマテリアルの色を指定された色に変更する。
      r.material.color = m_color;
    }
  }
}