using UnityEngine;

public class BladeLight : MonoBehaviour
{
    public Transform bladeBase;   // drag BladeBase here
    public float baseIntensity = 3f;
    public float flickerAmount = 0.5f;
    public float flickerSpeed = 10f;

    Light pointLight;

    void Start()
    {
        pointLight = GetComponent<Light>();
    }

    void Update()
    {
        // 0 when retracted, 1 when fully extended
        float extend = bladeBase.localScale.y;
        float flicker = 1f + (Mathf.PerlinNoise(Time.time * flickerSpeed, 0f) - 0.5f) * flickerAmount;
        pointLight.intensity = baseIntensity * extend * flicker;
    }
}