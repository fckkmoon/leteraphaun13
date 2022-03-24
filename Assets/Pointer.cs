using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pointer : MonoBehaviour
{
    private float Velocidade;
    private Vector2 Movimentacao;

    // Start is called before the first frame update
    void Start()
    {
        Velocidade = 2;
        Movimentacao = Vector2.zero;
    }

    // Update is called once per frame
    void Update()
    {
       Mover();

        transform.Translate(Movimentacao * Velocidade * Time.deltaTime);

        if (Input.GetKey(KeyCode.Space))
        {
            RaycastHit2D hit = Physics2D.Raycast(transform.position, transform.TransformDirection(Vector2.left), 10f);

            if (hit)
            {
                Debug.Log("Hit Something : " + hit.collider.name);
                hit.transform.GetComponent<SpriteRenderer>().color = Color.red;
            }
        }
    }

    void Mover()
    {
        Movimentacao = Vector2.zero;

        if(Input.GetKey(KeyCode.LeftArrow))
        {
            Movimentacao +=Vector2.down;
        }
        if(Input.GetKey(KeyCode.RightArrow))
        {
            Movimentacao +=Vector2.up;
        }
    }
}
