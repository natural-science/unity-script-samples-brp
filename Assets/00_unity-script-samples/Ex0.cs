using UnityEngine;

public class Ex0 : MonoBehaviour
{
  [SerializeField] private Transform teleportTo;
  [SerializeField] private Color color0;
  [SerializeField] private Color color1;
  [SerializeField] private Color color2;
  [SerializeField] private Color color3;
  private int collisionCount = 0;


  private void OnCollisionEnter(Collision other)
  {
    other.rigidbody.position = teleportTo.position;

    collisionCount = (collisionCount + 1) % 4;
    var color =
      (collisionCount == 0) ? color0 :
      (collisionCount == 1) ? color1 :
      (collisionCount == 2) ? color2 : color3;
    GetComponent<Renderer>().material.color = color;
  }
}
