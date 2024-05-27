using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scrLoginManager : MonoBehaviour
{

    //cuando el usuario apriente el botón debe escribirse el mensaje en consola
    //si el texto coincide con una contra predefinida escribir Access granted, sino Access denied

    public InputField inputField;
    public string password;
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Escribir()
    {
        Debug.Log(inputField.text);
        
        if (inputField.text == password)
        {
            Debug.Log("Acesso Granteado"); 
        } else
        {
            Debug.Log("Acesso Deniedado");
        }
    }
}
