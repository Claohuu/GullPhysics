using UnityEngine;
using System.Collections.Generic;
using Unity.Hierarchy;

public class PhysicsWorld : MonoBehaviour
{

    List<Body> bodies = new List<Body>();
    public Vector3 gravity = new Vector3(0f, -9.81f, 0f);

    public static PhysicsWorld Instance;
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    void Awake() {
        Instance = this;
    }

   void FixedUpdate() {
        float dt = Time.fixedDeltaTime;

        foreach (Body body in bodies) {
            body.velocity += gravity * dt;
            body.position += body.velocity * dt;

        }

    }
}
