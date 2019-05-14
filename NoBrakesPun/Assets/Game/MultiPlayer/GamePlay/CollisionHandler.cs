using System.Runtime.Serialization;
using UnityEngine;

public class CollisionHandler : MonoBehaviour
{
    public Rider rider;

    private void OnCollisionEnter(Collision collision)
    {
        if (rider.hasJob && !collision.gameObject.CompareTag("MapBase") && collision.relativeVelocity.magnitude > 45)
        {
            rider.FailMission();
        }
    }
}