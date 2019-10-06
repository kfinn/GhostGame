using UnityEngine;

public class Chasing : MonoBehaviour
{
  [HideInInspector]
  public float velocity;
  private const float MaxVelocity = 100;
  private const float MaxAcceleration = 30;
  private const float MaxBraking = 20;
  public Transform target;
  public float targetOffsetX;

  void Start()
  {

  }

  void Update()
  {
    var ballDistance = (target.position.x + targetOffsetX) - transform.position.x;
    var idealVelocity = Mathf.Sign(ballDistance) * 2 * MaxBraking * Mathf.Sqrt(Mathf.Abs(ballDistance) / MaxBraking);
    var idealAcceleration = idealVelocity - velocity;

    var accelerationBoundPerSecond = Mathf.Sign(idealAcceleration) == Mathf.Sign(velocity) ? MaxAcceleration : MaxBraking;
    var accelerationBound = accelerationBoundPerSecond * Time.deltaTime;
    var attainableIdealAcceleration = Mathf.Clamp(idealAcceleration, -accelerationBound, accelerationBound);

    velocity += attainableIdealAcceleration;
    velocity = Mathf.Clamp(velocity, -MaxVelocity, MaxVelocity);

    transform.position = new Vector3(
        transform.position.x + velocity * Time.deltaTime,
        transform.position.y,
        transform.position.z
    );
  }
}
