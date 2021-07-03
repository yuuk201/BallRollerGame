using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ToGameover : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Transform myTransform = this.transform;
 
        // 座標を取得
        Vector3 pos = myTransform.position;
        if(pos.y<0){
            SceneManager.LoadScene("gameover");
        }
    }
}
