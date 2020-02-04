using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public KeyCode m_LeftKeyCode = KeyCode.A;
    public KeyCode m_RightKeyCode = KeyCode.D;
    public KeyCode m_UpKeyCode = KeyCode.W;
    public KeyCode m_DownKeyCode = KeyCode.S;

    private NodoScript ActualNode;
    private Dictionary<string, GameObject> PossiblePositions;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        //Movimiento
        if (Input.GetKey(m_UpKeyCode) && PossiblePositions["Norte"] == true)
        {
            this.transform.position = PossiblePositions["Nord"].transform.position;
        }
        else if (Input.GetKey(m_DownKeyCode) && PossiblePositions["Sur"] == true)
        {
            this.transform.position = PossiblePositions["Sur"].transform.position;
        }
        else if (Input.GetKey(m_RightKeyCode) && PossiblePositions["Este"] == true)
        {
            this.transform.position = PossiblePositions["Este"].transform.position;
        }
        else if (Input.GetKey(m_LeftKeyCode) && PossiblePositions["Oeste"] == true)
        {
            this.transform.position = PossiblePositions["Oeste"].transform.position;
        }


    }

    void OnTriggerEnter2D(Collider2D _Collider)
    {
        Debug.Log("ontrigger");

        if (_Collider.tag == "Nodo")
        {
            Debug.Log("Collider");
            ActualNode = _Collider.GetComponent<NodoScript>();
            PossiblePositions = ActualNode.getDicionary();

        }
    }
}