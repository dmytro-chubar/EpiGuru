using UnityEngine;

public class CharacterMove : MonoBehaviour
{
    private float _moveSpeed = 2f;
    private float _touchSensitivity = 0.05f;
    private float _xLimit = 4.0f;

    private Vector2 _startTouchPosition;
    private Vector2 _currentTouchPosition;
    private bool _isTouching;

    private void Update () {
        MoveForward();
    }

    private void MoveForward () {
        transform.position += Vector3.forward * _moveSpeed * Time.deltaTime;


        if (Input.touchCount > 0) {
            Touch touch = Input.GetTouch(0);

            switch (touch.phase) {
                case TouchPhase.Began:
                    _startTouchPosition = touch.position;
                    _isTouching = true;
                    break;

                case TouchPhase.Moved:
                    if (_isTouching) {
                        _currentTouchPosition = touch.position;
                        Vector2 touchDelta = _currentTouchPosition - _startTouchPosition;

                        if (Mathf.Abs(touchDelta.x) > Mathf.Abs(touchDelta.y)) {
                            float deltaX = touchDelta.x * _touchSensitivity * Time.deltaTime;
                            Vector3 newPosition = transform.position + new Vector3(deltaX, 0, 0);
                            newPosition.x = Mathf.Clamp(newPosition.x, -_xLimit, _xLimit);
                            transform.position = newPosition;
                        }
                    }
                    break;

                case TouchPhase.Ended:
                case TouchPhase.Canceled:
                    _isTouching = false;
                    break;
            }
        }
    }
}
