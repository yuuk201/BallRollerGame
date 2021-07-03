using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;  // 追加しましょう

using UnityEngine.SceneManagement;
public class goal : MonoBehaviour {
  // 当たった時に呼ばれる関数
  public GameObject goaltext=null;
    void OnCollisionEnter(Collision other)
    {
        
        SceneManager.LoadScene("goal");

    }
}