using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class exit : MonoBehaviour
{
    public void ExitGame()
    {
#if UNITY_EDITOR
        // Unity Edit�r�nde �al���rken, oyunu durdurma
        UnityEditor.EditorApplication.isPlaying = false;
#else
        // Derlenmi� bir oyundayken, uygulamadan ��k�� yapma
        Application.Quit();
#endif
    }
}

