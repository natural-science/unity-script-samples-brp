﻿using UnityEngine;

// この講座のルール:
//         ↓↓↓↓↓↓↓↓ はフォルダの日付と合わせる
namespace _20241025_MonoBehaviourEssentials
{
  public class Hello0123 : MonoBehaviour
  {
    private int i = 0; 

    void Update()
    {
      Debug.Log(i);
      i = (i + 1) % 4;
    }
  }
}
