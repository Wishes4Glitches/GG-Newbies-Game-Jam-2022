using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MultiTargetCamera : MonoBehaviour
{
    /*public List<Transform> targets;

    public Vector2 offset;

    void LateUpdate()
    {

        if (targets.Count == 0)
            return;

        Vector2 centerPoint = GetCenterPoint();

        Vector2 newPosition = centerPoint + offset;

        transform.position = centerPoint;
    }

    Vector2 GetCenterPoint()
    {
        if (targets.Count == 1)
        {
            return targets[0].position;
        }

        var bounds = new Bounds(targets[0].position, Vector2.zero);
        for (int i = 0; i < targets.Count; i++)
        {
            bounds.Encapsulate(targets[i].position);
        }

        return bounds.center;
    }*/

    public Transform player1;
    public Transform player2;
    public Camera cam;

    private const float DISTANCE_MARGIN = 1.0f;

    private Vector3 middlePoint;
    private float distanceBetweenPlayers;
    private float cameraDistance;
    private float aspectRatio;
    private float tanFov;

    void Start()
    {
        aspectRatio = Screen.width / Screen.height;
        tanFov = Mathf.Tan(Mathf.Deg2Rad * Camera.main.fieldOfView / 2.0f);
    }

    void Update()
    {
        // Position the camera in the center.
        Vector3 newCameraPos = cam.transform.position;
        newCameraPos.x = middlePoint.x;
        cam.transform.position = newCameraPos;

        // Find the middle point between players.
        Vector3 vectorBetweenPlayers = player2.position - player1.position;
        middlePoint = player1.position + 0.5f * vectorBetweenPlayers;

        // Calculate the new distance.
        distanceBetweenPlayers = vectorBetweenPlayers.magnitude;
        cameraDistance = (distanceBetweenPlayers / 2.0f / aspectRatio) / tanFov;

        // Set camera to new position.
        Vector3 dir = (cam.transform.position - middlePoint).normalized;
        cam.transform.position = middlePoint + dir * (cameraDistance + DISTANCE_MARGIN);
    }
}
