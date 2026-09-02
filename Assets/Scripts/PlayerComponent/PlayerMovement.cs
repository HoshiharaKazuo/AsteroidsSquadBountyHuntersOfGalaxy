using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    [SerializeField]
    private float _velocity;

    public float Velocity
    {
        get => _velocity;
        set => _velocity = value;
    }


}
