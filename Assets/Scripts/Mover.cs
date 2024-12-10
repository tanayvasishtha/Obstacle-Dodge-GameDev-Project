using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField]float moveSpeed=10f;
    //here we are using SerializeField to make the variables visible in the inspector
    void Start()
    {

      PrintInstruction();
    }

    void Update()
    {
        MovePlayer();
    }

    void PrintInstruction(){
        Debug.Log("Welcome to the Game!");
        Debug.Log("WASD to move the object");
        Debug.Log("Don't bump into the walls and obstacles!");

    }

    void MovePlayer(){
        float xValue = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;
        float yValue = 0f;
        float zValue = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed;
        transform.Translate(xValue, yValue, zValue);
    }
}
