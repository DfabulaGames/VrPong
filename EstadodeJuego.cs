using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;


public class EstadodeJuego : MonoBehaviour {

    public int puntuacionMaxima = 0;

    public static EstadodeJuego estadodeJuego;

    private String rutaArchivo;

void Awake()
{
        rutaArchivo = Application.persistentDataPath +  "/datos.dat";
        if (estadodeJuego == null)
        {
            estadodeJuego = this;
            DontDestroyOnLoad(gameObject);
        }else  if (estadodeJuego != this){
        Destroy(gameObject);
        }
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

   public void Guardar(){

        BinaryFormatter bf = new BinaryFormatter();
        FileStream file = File.Create(rutaArchivo);

        DatosAGuardar datos = new DatosAGuardar(rutaArchivo);
        datos.puntuacionMaxima = puntuacionMaxima;

        bf.Serialize(file, datos);

        file.Close();
}
	
    void Cargar()
{
    if (File.Exists(rutaArchivo)){
        BinaryFormatter bf = new BinaryFormatter();
        FileStream file = File.Open(rutaArchivo, FileMode.Open);

        DatosAGuardar datos = (DatosAGuardar)bf.Deserialize(file);

        puntuacionMaxima = datos.puntuacionMaxima;
        
        file.Close();
        }else{

            puntuacionMaxima = 0;
        }

}

[Serializable]
class DatosAGuardar
{
    public int puntuacionMaxima;
    private string rutaArchivo;

    public DatosAGuardar(string rutaArchivo)
    {
        this.rutaArchivo = rutaArchivo;
    }

    public DatosAGuardar(int puntuacionMaxima){
        this.puntuacionMaxima = puntuacionMaxima;
    }
}
}

