using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class play : MonoBehaviour
{
    public string kanalizasyon; // Y�klemek istedi�iniz sahnenin ad�n� buraya yaz�n.

    private void Start()
    {
      
    }

    private void Update()
    {
        // Her frame g�ncellenmesi gereken i�lemleri burada yapabilirsiniz.
    }

    public void GecisYap()
    {
        SceneManager.LoadScene("kanalizasyon");
    }

}

