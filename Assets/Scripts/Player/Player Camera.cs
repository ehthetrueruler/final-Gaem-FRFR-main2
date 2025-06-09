using UnityEngine;

public class PlayerCamera : MonoBehaviour
{
    //x + y sensitivity
    public float sensX;
    public float sensY;
    // player orientation
    public Transform orientation;
    // camera rotation
    float xRotation;
    float yRotation;

    //locks cursor in center of screen
    private void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    private void Update()
    {
        //get mouse input
        float mouseX = Input.GetAxisRaw("Mouse X") * Time.deltaTime * sensX;
        float mouseY = Input.GetAxisRaw("Mouse Y") * Time.deltaTime * sensY;
        //limit camera rotation to 90 degrees up and down
        yRotation += mouseX;

        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -90f, 90f);
        //rotate camera and orientation
        transform.rotation = Quaternion.Euler(xRotation, yRotation, 0);
        orientation.rotation = Quaternion.Euler(0, yRotation, 0);
    }

}
