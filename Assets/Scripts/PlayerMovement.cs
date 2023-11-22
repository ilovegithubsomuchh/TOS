
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [Header("PlayerMoves")] private float _inputValueY;
    private float _inputValueX;
    private float _posX;
    private float _posY;
    private float _speed;


    // Start is called before the first frame update
    void Start()
    {

        _speed = 20f;
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
        _posX = (position.x + (_inputValueX * Time.deltaTime * _speed));
        _posY = (position.y + (_inputValueY * Time.deltaTime) * _speed);
        transform.position = new Vector2(_posX, _posY);
    }
}