using UnityEngine;
using UnityEngine.Rendering;

public class PhysicsBody : MonoBehaviour
{
    public float mass = 5f;
    private Body body;
    public float radius = 0.5f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        body = new Body(transform.position, mass, radius);
        PhysicsWorld.Instance.Register(body);
    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = body.position;
    }
}
