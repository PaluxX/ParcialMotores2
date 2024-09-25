using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Buttons : MonoBehaviour
{
    [SerializeField] public GameObject _menuOpc;
    [SerializeField] public GameObject _menuPrin;
    private void Start()
    {
        _menuOpc.SetActive(false);
    }
    public void Jugar()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

    }

    public void Opciones () 
    {
        _menuOpc.SetActive(true);
        _menuPrin.SetActive(false);
    }

    public void Volver() 
    {
        _menuOpc.SetActive(false);
        _menuPrin.SetActive(true);
    }
}
