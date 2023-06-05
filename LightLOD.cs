using UnityEngine;

public class LightLOD : MonoBehaviour
{
    public Light[] lights;
    public float[] distanceThresholds; //Mesafe
    public float[] intensities; //Iþýk Þiddeti
    public int calculationInterval = 5;

    private int frameCount = 0;

    private void Update()
    {
        frameCount++;
        if (frameCount >= calculationInterval)
        {
            Vector3 cameraPosition = Camera.main.transform.position;

            for (int i = 0; i < lights.Length; i++)
            {
                Light light = lights[i];
                float distance = Vector3.Distance(light.transform.position, cameraPosition);
                float intensity = CalculateIntensity(distance, distanceThresholds, intensities);

                light.intensity = intensity;
            }
            frameCount = 0;
        }
    }

    private float CalculateIntensity(float distance, float[] thresholds, float[] intensities)
    {
        if (distance < thresholds[0])
            return intensities[0];

        for (int i = 1; i < thresholds.Length; i++)
        {
            if (distance < thresholds[i])
            {
                float t = (distance - thresholds[i - 1]) / (thresholds[i] - thresholds[i - 1]);
                return Mathf.Lerp(intensities[i - 1], intensities[i], t);
            }
        }
        return intensities[intensities.Length - 1];
    }
}