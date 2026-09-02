using UnityEngine;

[CreateAssetMenu(fileName = "PlayerStats", menuName = "Custom/Stats/PlayerStats")]
public class PlayerStats : ScriptableObject
{
    [SerializeField]
    private string _name;

    [SerializeField]
    private float _vitality;

    [SerializeField]
    private float _velocity;

    [SerializeField]
    private GameObject _prefab;

    public string Name => _name;
    public float Vitality => _vitality;
    public float Velocity => _velocity;
    public GameObject Prefab => _prefab;
}
