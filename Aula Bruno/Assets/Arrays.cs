using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrays : MonoBehaviour
{
    //as listas começam no número 0, e vão até o infinito
    // Length pega a quantidade de itens de uma lista
    //var é uma variavel dinamica - se comporta de qualquer jeito
    int[] numeros = {10, 20, 30};
    int[] numeros2 = new int[5];
    string[] nomes = {"isaque", "yasmin", "padao", "heitor"};
    string[] poderes;
    
    // Start is called before the first frame update
    void Start()
    {
        poderes = new string[5];
        
        numeros[1] = 50;
        numeros2[4] = 20;
        for(int i = 0; i > nomes.Length; i++)
        {
            print(nomes[i]);
        }
        foreach(string nome in nomes)
        {
            print(nome);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
