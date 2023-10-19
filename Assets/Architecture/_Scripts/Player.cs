using UnityEngine;


[RequireComponent(typeof(Rigidbody2D))]
public class Player : MonoBehaviour
{

    #region Properties
    public int HeatPoint => _heatPoint;

    public float RunSpeed => _runSpeed;
    public float JumpForce => _jumpForce;

    public Rigidbody2D GetRigidbody2D => _rb;
    #endregion

    #region Field inspector
    [Header("Player Data")]
    [SerializeField] private int _heatPoint;

    [Header("Movement Data")]
    [SerializeField] private float _runSpeed;
    [SerializeField] private float _jumpForce;
    #endregion

    #region Player links
    private Rigidbody2D _rb;
    #endregion







    // Start is called before the first frame update
    void Awake()
    {
        _rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    class PlayerMovement { }
}
