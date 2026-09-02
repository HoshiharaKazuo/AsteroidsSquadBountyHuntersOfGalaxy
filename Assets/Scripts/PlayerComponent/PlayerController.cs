using UnityEngine;

public class PlayerController : MonoBehaviour
{
    
    [SerializeField]
    private PlayerStats _playerStats;
    
    [SerializeField]
    private PlayerMovement _playerMovement;

    [SerializeField]
    private HealthComponent _healthComponent;

    private GameObject _playerPrefab;

    private void Awake()
    {
        _playerMovement.Velocity = _playerStats.Velocity;
        _healthComponent.Vitality = _playerStats.Vitality;
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
          InstantiatePlayerPrefab();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void InstantiatePlayerPrefab()
    {
        _playerPrefab = Instantiate(_playerStats.Prefab, transform.position, Quaternion.identity, transform);
        _playerPrefab.transform.position = Vector3.zero;
    }

    
}
