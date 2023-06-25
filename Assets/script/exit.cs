using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class exit : MonoBehaviour
{
    public void ExitGame()
    {
#if UNITY_EDITOR
        // Unity Editöründe çalýþýrken, oyunu durdurma
        UnityEditor.EditorApplication.isPlaying = false;
#else
        // Derlenmiþ bir oyundayken, uygulamadan çýkýþ yapma
        Application.Quit();
#endif
    }
}

