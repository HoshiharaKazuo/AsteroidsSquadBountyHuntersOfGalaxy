using UnityEngine;

public class HealthComponent : MonoBehaviour
{
    
    [SerializeField]
    private float _vitality;

    public float Vitality 
    {
        get => _vitality;
        set => _vitality = value;
    }
    
}
