using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Objeto_Equipado : MonoBehaviour
{
    // Start is called before the first frame update
    public bool ocupada = false;
    public string objeto_equipado_name;
    Image imagen_equipada;
    void Start()
    {
        imagen_equipada = this.GetComponent<Image>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if (!ocupada)
            imagen_equipada.enabled = false;

        else
            imagen_equipada.enabled = true;

    }

    public void UpdateImage(Sprite Imagen_nueva)
    {
        
        imagen_equipada.sprite = Imagen_nueva;
    }
}
