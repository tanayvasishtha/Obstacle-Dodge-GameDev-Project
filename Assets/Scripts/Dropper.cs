using UnityEngine;

public class Dropper : MonoBehaviour
{
    [SerializeField]float timetoWait=2f;

    MeshRenderer MyMeshrenderer;
    Rigidbody MyRigidbody;
    void Start()
    {//Caching is a tecnique to store the value of a variable in a memory location so that it can be accessed faster
        
        MyMeshrenderer = GetComponent<MeshRenderer>();
        MyRigidbody = GetComponent<Rigidbody>();

        MyMeshrenderer.enabled = false;
        MyRigidbody.useGravity = false;
    }

    void Update()
    {
        if (Time.time > timetoWait)
        {
         MyMeshrenderer.enabled = true;
         MyRigidbody.useGravity = true;
        }
    }
}
