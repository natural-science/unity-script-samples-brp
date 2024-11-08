using UnityEngine;

public class TestTransform : MonoBehaviour
{
  [SerializeField] private GameObject o0;
  [SerializeField] private GameObject o1;
  [SerializeField] private GameObject o2;

  void Update()
  {
    o1.transform.position = (o0.transform.position + o2.transform.position) / 2f;
  }
}
