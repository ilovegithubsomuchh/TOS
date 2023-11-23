
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [Header("PlayerMoves")] private float _inputValueY;
    private float _inputValueX;
    private float _posX;
    private float _posY;
    
    
    [SerializeField] private float speed;
    [SerializeField] private float BORDMINX;
    [SerializeField] private float BORDMINY;
    [SerializeField] private float BORDMAXX;
    [SerializeField] private float BORDMAXY;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        _inputValueX = Input.GetAxis("Horizontal");
        _inputValueY = Input.GetAxis("Vertical");
        if (_inputValueY != 0 || _inputValueX != 0) Move();
    }

    void Move()
    {
        var position = transform.position;
        _posX = (position.x + (_inputValueX * Time.deltaTime * speed));
        _posY = (position.y + (_inputValueY * Time.deltaTime) * speed);
        _posX = Mathf.Clamp(_posX, BORDMINX, BORDMAXX);
        _posY = Mathf.Clamp(_posY, BORDMINY, BORDMAXY);
        transform.position = new Vector2(_posX, _posY);
    }
}