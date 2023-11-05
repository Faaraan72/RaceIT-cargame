using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    private const string HORIZONTAL = "Horizontal";
    private const string VERTICAL = "Vertical";

    private float horizontalInput;
    private float verticalInput;
    public GameObject backlight1, backlight2;

    private float csa;//current steering angle
    private float cbf; // current breaking force
    private bool isbreaking;
    private Rigidbody rb;
    private float gasinp;
    public bool breakinp;

    [SerializeField] private float motorforce, breakForce, maxSteeringangle;
    [SerializeField] private WheelCollider frontrightwc, frontleftwc, backrightwc, backleftwc;
    [SerializeField] private Transform frontrightTransforms, frontleftTransforms, backrightTransforms, backleftTransforms;


    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        backlight1.SetActive(false);
        backlight2.SetActive(false);

    }
    public void gaspressed()
    {
        gasinp = 1;
    }
    public void gasreleased()
    {
        gasinp = 0;
    }
    public void reversepress()
    {
        gasinp = -1;
        backlight1.SetActive(true);
        backlight2.SetActive(true);

    }
    public void reversedreleased()
    {
        gasinp = 0;
        backlight1.SetActive(false);
        backlight2.SetActive(false);

    }
    public void breakpressed()
    {
        breakinp = true;
        backlight1.SetActive(true);
        backlight2.SetActive(true);
    }
    public void breakreleased()
    {
        breakinp = false;
        backlight1.SetActive(false);
        backlight2.SetActive(false);
    }
    private void FixedUpdate()
    {
        GetInput();
        HandelMotor();
        HandelSteering();
       
        updateWheels();
        died();

    }
   
        
    public Vector3 pos;
    public Quaternion rot;
    private void died()
    {
        pos = rb.transform.position;
        rot = rb.transform.rotation;

        if(rb.rotation.x > 90 || rb.rotation.x < -90 || rb.rotation.z > 90 || rb.rotation.z < -90)
        {
            pos = rb.transform.position;
            Debug.Log("Died");
            Invoke(nameof(again), 2f);
            
        }

    }
    private void again()
    {
        Debug.Log("restarting");
        rb.transform.position = new Vector3(pos.x, pos.y + 5, pos.z + 5);
       
    }
    private void GetInput()
    {
        horizontalInput = SimpleInput.GetAxis(HORIZONTAL);
        verticalInput = gasinp;
        isbreaking = breakinp;
    }

    private void HandelMotor()
    {
        frontleftwc.motorTorque = verticalInput * motorforce;
        frontrightwc.motorTorque = verticalInput * motorforce;
        cbf = isbreaking ? breakForce : 0f;
        ApplyBreaking();
    }

    private void ApplyBreaking()
    {
        frontleftwc.brakeTorque = cbf;
        frontrightwc.brakeTorque = cbf;
        backleftwc.brakeTorque = cbf;
        backrightwc.brakeTorque = cbf;

    }

    private void HandelSteering()
    {
        csa = maxSteeringangle * horizontalInput;
        frontleftwc.steerAngle = csa;
        frontrightwc.steerAngle = csa;

    }

    private void updateWheels()
    {
        UpdateSingleWheel(frontleftwc, frontleftTransforms);
        UpdateSingleWheel(frontrightwc, frontrightTransforms);
        UpdateSingleWheel(backleftwc, backleftTransforms);
        UpdateSingleWheel(backrightwc, backrightTransforms);

    }

    private void UpdateSingleWheel(WheelCollider wc, Transform wheelTransform)
    {
        Vector3 pos;
        Quaternion rot;
        wc.GetWorldPose(out pos, out rot);
        wheelTransform.rotation = rot;
        wheelTransform.position = pos;
    }

}
