using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AV1Behaviour : MonoBehaviour
{  
    public List<Entrada> List  = new List<Entrada>(0);

   
    public void Add(string key, int value)
    {
        Entrada entrada = new Entrada();
        entrada.key = key;
        entrada.value = value;
        List.Add(entrada);
    }







    public void Remove(int index)
    {
        List.RemoveAt(index);
    }
   
}
public class Entrada
{
    public string key;
    public int value;
}


