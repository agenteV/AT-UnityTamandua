using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sucuarana : MonoBehaviour
{
    [SerializeField]
    private float velocidade = 3;

    //cria a variavel fisica do tipo Rigidbody
    Rigidbody2D fisica;

    //método Awake é chamado toda vez que o objeto é criado
    private void Awake()
    {
        //adiciona à variavel física o componente RigidBody daquele objeto ativo no momento
        this.fisica = this.GetComponent<Rigidbody2D>();
    }
    //métodos private somente nossa classe pode acessar
    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("Clicou");
            //chama o método impulsionar
            //o this serve para indicar que é o objeto ativo naquele momento que recerá ação
           
        }
    }
    
  
}
