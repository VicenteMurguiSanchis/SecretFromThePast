using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Contenido_Texto : MonoBehaviour
{

    public int text_num;
    private string[] texto_cargado;

    private void Awake()
    {
        text_num = 0;
    }

    private void Update()
    {
        if(Input.GetButtonDown("Fire1") && this.gameObject.activeSelf)
        {
            text_num++;
            if(text_num >= texto_cargado.Length)
            {
                text_num = 0;
                this.gameObject.SetActive(false);
            }

            else
            {
                UpdateTexto();
            }
        }
    }

    // Start is called before the first frame update
    public void CargarTexto(string[] texto_nuevo)
    {
        texto_cargado = texto_nuevo;
        UpdateTexto();
    }

    public void UpdateTexto()
    {
        this.GetComponentInChildren<Text>().text = texto_cargado[text_num];
    }
}
