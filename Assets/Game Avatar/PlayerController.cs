using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 1f;
    [SerializeField] private Camera followCamera;
    [SerializeField] private float rotationSpeed = 1f;
    [SerializeField] private Transform followTarget;

    private Rigidbody rigidbody;

    private void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        Movement();
    }

    void Movement()
    {
        float verticalInput = Input.GetAxis("Vertical");
        float rotationInput = Input.GetAxis("Horizontal");

        followTarget.transform.eulerAngles = new Vector3(followTarget.transform.eulerAngles.x, followTarget.transform.eulerAngles.y + rotationInput, 0);

        Vector3 movementInput = Quaternion.Euler(0, followTarget.transform.eulerAngles.y, 0) * new Vector3(0, 0, verticalInput);
        Vector3 movementDirection = movementInput.normalized;

        rigidbody.AddForce(movementDirection * moveSpeed * 100 * Time.deltaTime);
    }
        

    private bool GetInputHorizontal()
    {
        return (Input.GetKey(KeyCode.W) ||
            Input.GetKey(KeyCode.S) ||
            Input.GetKey(KeyCode.UpArrow) ||
            Input.GetKey(KeyCode.DownArrow));
    }
}
