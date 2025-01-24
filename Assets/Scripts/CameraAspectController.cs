using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
public class CameraAspectController : MonoBehaviour
{
    private Camera cam;
    [SerializeField] private float fieldOfViewDegree;

    private enum FOVMode
    {
        Vertical,
        Horizontal
    };

    [SerializeField] private FOVMode fovMode;

    private void Awake()
    {
        cam = GetComponent<Camera>();
    }

    private void FixedUpdate()
    {
        float currentAspectRatio = cam.aspect;
        float verticalFov = 0;
        switch (fovMode)
        {
            case FOVMode.Vertical: // this.fieldOfViewDegreeが垂直画角
                verticalFov = fieldOfViewDegree;
                break;
            case FOVMode.Horizontal: // this.fieldOfViewDegreeが水平画角
                verticalFov = HorizontalToVerticalFov(fieldOfViewDegree, currentAspectRatio);
                break;
        }

        cam.fieldOfView = verticalFov;
    }

    private float HorizontalToVerticalFov(float horizontalFov, float aspectRatio)
    {
        return 2f * Mathf.Rad2Deg * Mathf.Atan(Mathf.Tan(horizontalFov * 0.5f * Mathf.Deg2Rad) / aspectRatio);
    }

    private float VerticalToHorizontalFov(float verticalFov, float aspectRatio)
    {
        return 2f * Mathf.Rad2Deg * Mathf.Atan(Mathf.Tan(verticalFov * 0.5f * Mathf.Deg2Rad) * aspectRatio);
    }
}