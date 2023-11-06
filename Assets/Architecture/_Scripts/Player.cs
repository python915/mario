using UnityEngine;

namespace Mario.Assets.Architecture._Scripts
{
    [RequireComponent(typeof(Rigidbody2D))]
    public class Player : MonoBehaviour
    {

        #region Properties
        public int Health => _playerHealth;
        public int MaxHealth => _maxHealthPlayer;

        public float SpeedRun => _speedRun;
        public float ForceJump => _forceJump;

        public Rigidbody2D GetRigidbody2D => _rb;
        #endregion

        #region Field inspector
        [Header("Player Data")]
        [SerializeField] private int _playerHealth;
        [SerializeField] private int _maxHealthPlayer;

        [Header("Movement Data")]
        [SerializeField][Range(2, 10)] private float _speedRun;
        [SerializeField][Range(2, 10)] private float _forceJump;
        #endregion

        #region
        [Header("Player links")]
        private Rigidbody2D _rb;
        #endregion





        // Start is called before the first frame update
        private void Start()
        {
            _rb = GetComponent<Rigidbody2D>();
        }

        // Update is called once per frame
        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.Space)) Jump();
        }

        private void FixedUpdate()
        {
            Run();
        }

        private void Run()
        {
            var derectionX = Input.GetAxisRaw("Horizontal");
            var velocity = new Vector2(derectionX * _speedRun, _rb.velocity.y);
            _rb.velocity = velocity;

        }

        private void Jump()
        {
            _rb.AddForce(Vector2.up * _forceJump, ForceMode2D.Impulse);
        }

        private void BigJump()
        {
            _rb.AddForce(Vector2.up * (_forceJump * 2), ForceMode2D.Impulse);
        }

        private void OnTriggerEnter2D(Collider2D collision)
        {
            if(collision.gameObject.tag == "Jump")
            {
                BigJump();
                Destroy(collision.gameObject);

            }
            if(collision.gameObject.tag == "Destroy")
            {
                Destroy(collision.gameObject);
            }
        }


    }

}