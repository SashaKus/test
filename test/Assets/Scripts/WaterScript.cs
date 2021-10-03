using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    //������� ����
    private void OnTriggerEnter2D(Collider2D collision)
    {
        GameObject collisionWith = collision.gameObject;
        if (collisionWith.tag == "Player")
        {
            SqareScript squareScript = collisionWith.GetComponent<SqareScript>();
            squareScript.ChangeSpeed(0.03f);
        }
    }
    //����� ������� ����
    private void OnTriggerExit2D(Collider2D collision)
    {
        GameObject collisionWith = collision.gameObject;
        if (collisionWith.tag == "Player")
        {
            SqareScript squareScript = collisionWith.GetComponent<SqareScript>();
            squareScript.ChangeSpeed(0.06f);
        }
    }
}
