using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColetarDengue : MonoBehaviour
{
        private void OnCollisionEnter2D(Collision2D collision)
        
        {
            if (collision.gameObject.name.Equals("Tamandua"))
            {
                Destroy(collision.gameObject);

            }

        }

}
