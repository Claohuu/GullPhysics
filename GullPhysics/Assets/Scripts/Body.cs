using UnityEngine;

public class Body
{
    public Vector3 position;
    public Vector3 velocity;
    public float mass; 

    public Body(Vector3 startPosition, float bodyMass) {
        position = startPosition;
        mass = bodyMass;
        velocity = Vector3.zero;
    }
}
