using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwerveMovement : MonoBehaviour
{
    private SwerveInputSystem _swerveInputSystem;
    [SerializeField] private float fallingSpeed;
    [SerializeField] private float swerveSpeed = 0.5f;
    [SerializeField] private float maxSwerveAmount = 1f;

    private void Awake()
    {
        _swerveInputSystem = GetComponent<SwerveInputSystem>();
    }

    private void Update()
    {
        float swerveAmountX = Time.deltaTime * swerveSpeed * _swerveInputSystem.MoveFactorX;
        swerveAmountX = Mathf.Clamp(swerveAmountX, -maxSwerveAmount, maxSwerveAmount);
        transform.Translate(swerveAmountX, -fallingSpeed, 0);
      //  float swerveAmountY = Time.deltaTime * swerveSpeed * _swerveInputSystem.MoveFactorY;
      //  swerveAmountY = Mathf.Clamp(swerveAmountY, -maxSwerveAmount, maxSwerveAmount);
      //  transform.Translate(0, swerveAmountY, 0);
    }
}