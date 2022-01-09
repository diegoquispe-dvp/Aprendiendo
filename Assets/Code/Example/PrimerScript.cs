//librerias
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrimerScript : MonoBehaviour
{
 
    /*
    Camentario extendido - Aprendiendo C#
    

    //Guarda números enteros sin decimales
    int entero = 1;

    //Guarda número con decimales, se tiene que declarar f al final del número también
    float flotante = 1.44f;

    //Guarda enteros mas grandes
    long largo = 44444444;

    //Double guarda decimales muy grandes
    double doble = 3.222222222;

    //Guarda texto
    string frase = "Hola Mundo";

    //Guarda caracteres
    char letra = 'A';

    //Boleanos; True o False
    bool booleano = true;

   */
    // Start is called before the first frame update


 //Operaciones con Variables
    
    /*int a = 1, b = 2;
    // * + - / % // operaciones matemáticas
    //Se tienen que definir todas las variables que se van a usar
    int resultado;
    //int resultado = 0; //es válido también
    */









/*
//Condiciones de control If

//Operadores de control
// < > <= >= == !=
// && -> Y
// || -> O
// !  -> Not
    
    int level = 19;
    bool llave = false;
    void Start() //Se ejecuta al iniciar el juego
    {
        if (level >= 20 || llave)
        {
            Debug.Log("Puedes pasar al siguiente level");
        }
        else
        {
            Debug.Log("Vuelve a por una llave para entrar al calabozo");
        }

    }


*/

//Sentencia Switch

    //int condicion = 1;
  //  void Start()
 //   {
       /*switch (condicion)
        {
            case 1:
                Debug.Log("Ataque Básico");
                break;
            case 2:
                Debug.Log("Ataque Fuerte");
                break;
            case 3:
                Debug.Log("Ataque Magico");
                break;
            case 4:
                Debug.Log("Magia Curativa");
                break;
            default:
                Debug.Log("No hacer nada");
                break;
        }*/
        
        //while
        /*
        while (condicion<5)
        {
             Debug.Log("Hola");
             condicion++;
        }
        */
        //do while
        //do
     //   {
          //  Debug.Log("Hola");
    //    } while (true);
        
  //  }
    


 /* bucle for y array (array tiene que tener valores prestablecidos)

    int[] array = { 2, 5, 7, 0, 3 }; // hay 5 valores pero hay un índice máximo de 4

    float[] arrayFloat= new float[5]; //define explicitamente el número de valores dentro del array
    private void Start()
    {
        arrayFloat[0] = 2.5f;
        arrayFloat[1] = 2.6f;
        arrayFloat[0] = 2.5f;
        arrayFloat[0] = 2.5f;
        arrayFloat[0] = 2.5f;
        for (int i = 0; i < arrayFloat.Length; i++)
        {
            Debug.Log(arrayFloat[i]);
        }
    }

*/

/*Listas y for each (listas- lo mismo que array pero pueden crearse valores indefinidos, vacio, quitar elementos, añadir,etc.)
    
    List<int> numerosEnteros=new List<int>();
    List<float> numerosFlotantes=new List<float>();
    List<string> nombres=new List<string>();

    int[] numeros = {3,10,3,-4};

    string frase = "Me gusta Half Life";

    private void Start() 
    {
        numerosEnteros.Add(1);
        numerosEnteros.Add(2);
        numerosEnteros.Add(3);
        numerosEnteros.Insert(0,12); //index,valor a agregar
        //numerosEnteros.Remove(3); //borra el valor si esta en la lista
        //numerosEnteros.RemoveAt(0); //borra el valor que este en el index indicado
        //Debug.Log(numerosEnteros.Count);

        foreach (int numero in numerosEnteros)
        {
           // Debug.Log(numero);
        }    

        foreach (char letra in frase)
        {
            //Debug.Log(letra);
        }

        foreach (int numero in numeros)
        {
            Debug.Log(numero);
        }
    }
*/

/*metodos y funciones
   private void Start() {
        
    }

    private void Update()
    {
    
    }


    //Igual que el Update, funciona mejor para el tema de las Físicas.
    private void FixedUpdate() 
    {
        
    }

    //Se ejecuta como último Update de los existentes
    private void LateUpdate() {
        
    }

    //Ese objeto en específico se desactiva
    private void OnDisable() {
        Debug.Log("OnDisable");
    }
    //Ese objeto en específico se activa
    private void OnEnable() {
        Debug.Log("OnEnable");
    }
    
    
    
    //public float a = 1, b = 2;
    private void Start() 
    {
        Sumar(4,5);  //Es un método. Un método es una porción de código.  
    }

    private void Sumar(float a, float b)
    {
        float suma = a + b;
        Debug.Log(suma);
    }
    

    private void Start() 
    {
        string respuestaMetodo;
        respuestaMetodo = Respuesta("Adios");
        Debug.Log(respuestaMetodo);
    } 
    public string Respuesta(string palabra)
    {
        if (palabra == "Hola")
        {
            return "buenos dias";
        }
        else if (palabra == "Adios")
        {
            return "nos vemos";
        }
        else
        {
            return "No entiendo"; //siempre es neceseario un return para que asi la función tenga siempre una respuesta a la ruta que se elija (if).           
        }
    }
*/


/*
//modificar componentes


    private void Start() 
    {
        //Debug.Log(gameObject.activeSelf); //si el objeto no está activado, tampoco se activa su script incrustado.
        //gameObject.SetActive(false); //activa o desactiva elgameObject 
        //gameObject.AddComponent<Rigidbody>(); //le da fisicas al componente
        
        //Debug.Log(gameObject.name);

        //Debug.Log(transform.position);
        //gameObject.transform.position = new Vector3(3,0,6); //X, Y, Z
        //transform.position = new Vector3(3,2,6);
        //Debug.Log(transform.position);
        transform.rotation = Quaternion.Euler(45,90,0); //rotación Unity es en 4 ejes, pero con Quaternion.Euler lo hace solo con 3 ejes la rotación.
        transform.localScale = new Vector3(transform.localScale.x,8,7); //se puede mantener el valor especificando el actual valor del eje
    }   

*/

/*
//Invoke, Destroy, Cor-utinas
    private void Start() 
    {
        Invoke("Disparar",3);

        Destroy(gameObject,1);
    
    }

    private void Update() 
    {
        
    }

    // IEnumerator Corutina(float time)
    // {
    //     Debug.Log("Hola");
    //     yield return new WaitForSeconds(time); //Para no actualizar cada frame, sino cada co-rutina
    //     Debug.Log("Wenas");
    //     yield return new WaitForSeconds(time);
    //     StartCoroutine("Corutina",1); //Llamar la corutina al acabar la misma, con esto se forma un bucle
    //                                   //en todas las referencias donde se inicie la corutina y se tenga parametros adicionales, se tienen que llamar también a esos parámetros.
    // }


    void Disparar()
    {
        Debug.Log("Disparo");
    }
*/

/*
//Guardar información sobre el videojuego, vidas, monedas, nivel, etc.
//Solo se pueden guardar Int, float y string y tienen que ser independientes. (Guardados 1x1)
    int vida;
    string jugador;
    string estado;
    int level;
   
    private void Start()
    {
        PlayerPrefs.SetInt("Level",30); //Guarda valores en la memoria en formato clave,valor.
        PlayerPrefs.SetInt("Vida",24);
        PlayerPrefs.SetString("Nombre_Personaje","Diego");

        vida = PlayerPrefs.GetInt("Vida"); //Obtiene el valor que tiene la clave especificada.
        jugador = PlayerPrefs.GetString("Nombre_Personaje");
        level = PlayerPrefs.GetInt("Level");

        if (vida <= 50)
        {
            estado = ":(";
        }
        else
        {
            estado = ":)";
        }
    }
    
    private void Update()
    {
        Debug.Log("El jugador "+jugador+" tiene "+vida+" de vida "+estado+" y es de level "+level);
    }
*/

}

