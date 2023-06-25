using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class play : MonoBehaviour
{
    public string kanalizasyon; // Yüklemek istediðiniz sahnenin adýný buraya yazýn.

    private void Start()
    {
      
    }

    private void Update()
    {
        // Her frame güncellenmesi gereken iþlemleri burada yapabilirsiniz.
    }

    public void GecisYap()
    {
        SceneManager.LoadScene("kanalizasyon");
    }

}

