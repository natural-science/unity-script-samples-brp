using _20241025_MonoBehaviourEssentials;
using UnityEngine;

namespace _00_unity_script_samples.Scripts.OnCollision
{
  public class OnCollisionPlayAudioClip : MonoBehaviour
  {
    /// <summary>
    /// </summary>
    [SerializeField] private AudioSource m_audioSource;
    [SerializeField] private AudioClip m_audioClip;

    /// <summary>
    /// </summary>
    /// <param name="other">/// 衝突の情報を含む Collision オブジェクト。</param>
    private void OnCollisionEnter(Collision other)
    {
      m_audioSource.PlayOneShot(m_audioClip);
    }
  }
}
