using UnityEngine;
using UnityEngine.InputSystem;

public class LightsaberBlade : MonoBehaviour
{
    public GameObject blade;
    public float extendTime = 0.1f; 
    const float SCALE_MIN = 0f;

    float scaleMax, scaleCurrent, extendDelta, localScaleX, localScaleZ;
    bool weaponActive;

    void Start()
    {
        localScaleX = transform.localScale.x;
        localScaleZ = transform.localScale.z;
        scaleMax = transform.localScale.y;
        scaleCurrent = scaleMax;
        extendDelta = scaleMax / extendTime;
        weaponActive = true;
    }

    void Update()
    {
        if (Keyboard.current != null && Keyboard.current.spaceKey.wasPressedThisFrame)
            extendDelta = weaponActive ? -Mathf.Abs(extendDelta) : Mathf.Abs(extendDelta);

        scaleCurrent += extendDelta * Time.deltaTime;
        scaleCurrent = Mathf.Clamp(scaleCurrent, SCALE_MIN, scaleMax);
        transform.localScale = new Vector3(localScaleX, scaleCurrent, localScaleZ);
        weaponActive = scaleCurrent > 0;

        if (weaponActive && !blade.activeSelf) blade.SetActive(true);
        else if (!weaponActive && blade.activeSelf) blade.SetActive(false);
    }
}