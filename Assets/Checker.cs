using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Checker : MonoBehaviour
{
    public DeleteObject target;
    void OnDisable()
    {
        target.OnDestroyed.RemoveAllListeners();
    }
    void OnEnable()
    {
        target.OnDestroyed.AddListener(() => {
            Debug.Log("targetがDestroyされました");
            // ここに処理を追加
        });
    }
}