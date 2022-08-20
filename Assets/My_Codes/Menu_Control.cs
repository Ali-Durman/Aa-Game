using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu_Control : MonoBehaviour
{

    void Start()
    {
        // PlayerPrefs.DeleteAll(); bu kay�t silmeyi bir kere �al��t�r�p kay�tlar�m��zn hepsini sildirip sonra yorum sat�r� yapmal�y�z
        // oyunu kontrol ama�l� yazd�k asla build ederken yorum sat�r� yapmadan build etmeyin
    }

    public void OyunaBasla()
    {
        int kayitlilevel = PlayerPrefs.GetInt("kayit");

        if (kayitlilevel == 0)
        {
            SceneManager.LoadScene(kayitlilevel+1);
        }
        else
        {
            SceneManager.LoadScene(kayitlilevel);
        }
    }

    public void OyundanCik()
    {
        Application.Quit();
    }
}
