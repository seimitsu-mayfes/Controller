using UnityEngine;

public class SocketClient : MonoBehaviour
{
    // 左スティックの入力を取得
    public float horizontalInput;
    public float verticalInput;
    public float dPadHorizontal;
    public float dPadVertical;
    public bool buttonA;
    public bool buttonB;
    public bool buttonX;
    public bool buttonY;
    public bool L1;
    public float L2;

    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");
        dPadHorizontal = Input.GetAxis("DPadHorizontal");
        dPadVertical = Input.GetAxis("DPadVertical");
        buttonA = Input.GetButton("Fire1");
        buttonB = Input.GetButton("Fire2");
        buttonX = Input.GetButton("Fire3");
        buttonY = Input.GetButton("Fire4");
        L1 = Input.GetButton("L1");
        L2 = Input.GetAxis("L2");

        if (L1)
        {
            Debug.Log("L1");
        }

        if (L2 == 1)
        {
            Debug.Log("L2");
        }
    }
}